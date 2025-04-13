using System;
using System.Collections.Generic;
using System.IO;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ExcelDataReader;

namespace SmlLabelChecker
{
    public static class ReceptionHistory
    {
        private static Dictionary<int, ReceptionItem> _receptionItems = new Dictionary<int, ReceptionItem>();

        public static void Foreach(Action<ReceptionItem> _callback)
        {
            if (_receptionItems.Count == 0)
            {
                _callback?.Invoke(null); // 딕셔너리가 비어있으면 null로 콜백 호출
            }
            else
            {
                // 접수번호 순으로 정렬된 순서대로 순회
                var sortedItems = _receptionItems.OrderBy(kvp => kvp.Key);
                foreach (var kvp in sortedItems)
                {
                    _callback?.Invoke(kvp.Value);
                }
            }
        }

        public static ReceptionItem Find(int receptionNumber)
        {
            return _receptionItems.TryGetValue(receptionNumber, out var item) ? item : null;
        }

        public static bool Read(string excelPath, out string errorMessage, out string applyDate)
        {
            errorMessage = string.Empty;
            applyDate = string.Empty;

            try
            {
                // 엑셀 파일 읽기 설정
                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
                using (var stream = File.Open(excelPath, FileMode.Open, FileAccess.Read))
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    // 데이터셋으로 변환
                    var result = reader.AsDataSet();
                    var table = result.Tables[0]; // 첫 번째 시트 사용

                    applyDate = table.Rows[1][0].ToString();
                    
                    // 행 순회 (첫 번째 행은 헤더이므로 1부터 시작)
                    for (int rowIndex = 1; rowIndex < table.Rows.Count; rowIndex++)
                    {
                        var row = table.Rows[rowIndex];
                        
                        // 접수번호 (B열, 인덱스 1)
                        if (!int.TryParse(row[1]?.ToString(), out int receptionNumber))
                            continue; // 접수번호가 유효하지 않으면 건너뜀
                        
                        // 딕셔너리에 해당 접수번호가 없으면 새로 추가
                        if (!_receptionItems.ContainsKey(receptionNumber))
                        {
                            _receptionItems[receptionNumber] = new ReceptionItem
                            {
                                ReceptionNumber = receptionNumber,
                                TestItem = new List<ReceptionItem.Test>()
                            };
                        }

                        var item = _receptionItems[receptionNumber];

                        // 병원 (T열, 인덱스 19)
                        string hospitalStringCode = row[3]?.ToString();
                        string hospitalName = row[19]?.ToString();
                        if (!string.IsNullOrEmpty(hospitalName) && int.TryParse(hospitalStringCode, out int hospitalCode))
                        {
                            item.Hospital = new Hospital()
                            {
                                Code = hospitalCode,
                                Name = hospitalName
                            };
                        }


                        // 이름 (G열, 인덱스 6)
                        string name = row[6]?.ToString();
                        item.Name = name;

                        // TestItem (U/V 열만 사용, 인덱스 20/21)
                        string testName = row[20]?.ToString(); // U열
                        string sampleName = row[21]?.ToString(); // V열
                        string specimenCode = row[5]?.ToString(); // F열
                        int testCode = Convert.ToInt32(row[4]?.ToString()); // E열
                        
                        if (!string.IsNullOrEmpty(testName) && !string.IsNullOrEmpty(sampleName) && !string.IsNullOrEmpty(specimenCode))
                        {
                            item.TestItem.Add(new ReceptionItem.Test
                            {
                                TestName = testName,
                                TestCode = testCode,
                                SpecimenName = sampleName,
                                SpecimenCode = specimenCode
                            });
                        }

                        // 접수된 검체 수 (AA열, 인덱스 26) - 마지막 행에서만 반영
                        string sampleCountStr = row[26]?.ToString();
                        if (!string.IsNullOrEmpty(sampleCountStr))
                        {
                            if (int.TryParse(sampleCountStr, out int sampleCount))
                            {
                                // 해당 접수번호의 마지막 행인지 확인
                                bool isLastRow = true;
                                for (int j = rowIndex + 1; j < table.Rows.Count; j++)
                                {
                                    if (int.TryParse(table.Rows[j][1]?.ToString(), out int nextReceptionNumber) &&
                                        nextReceptionNumber == receptionNumber)
                                    {
                                        isLastRow = false;
                                        break;
                                    }
                                }

                                if (isLastRow)
                                {
                                    item.ReceivedSampleCount = sampleCount;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }

            return true;
        }
    }

    public class Hospital
    {
        public int Code;
        public string Name;
    }
    public class ReceptionItem
    {
        public int ReceptionNumber { get; set; }
        public Hospital Hospital { get; set; }
        public string Name { get; set; }
        public List<Test> TestItem { get; set; }
        public int ReceivedSampleCount { get; set; }

        public class Test
        {
            public string TestName { get; set; }
            public int TestCode { get; set; }
            public string SpecimenName { get; set; }
            public string SpecimenCode { get; set; }
        }
    }
}