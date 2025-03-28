﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Win32;
using Newtonsoft.Json;

namespace SmlLabelChecker
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
            LabelSettingDrop.SelectedIndex = 0; // 드롭다운 디폴트 0번 인덱스
            LoadFromRegistry(); // 폼 로드 시 기존 데이터 불러오기
        }

        private void LoadFromRegistry()
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\SmlLabelChecker"))
                {
                    if (key != null)
                    {
                        string jsonData = key.GetValue("LabelSettingData")?.ToString();
                        if (!string.IsNullOrEmpty(jsonData))
                        {
                            List<LabelSettingData> dataList = JsonConvert.DeserializeObject<List<LabelSettingData>>(jsonData);
                            RefreshDataView(dataList);
                        }
                    }
                }
            }
            catch (JsonException ex)
            {
                MessageBox.Show($@"JSON 파싱 오류: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($@"오류 발생: {ex.Message}");
            }
        }

        private void SaveToRegistry(List<LabelSettingData> newData)
        {
            try
            {
                List<LabelSettingData> existingData = new List<LabelSettingData>();
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\SmlLabelChecker"))
                {
                    if (key != null)
                    {
                        string jsonData = key.GetValue("LabelSettingData")?.ToString();
                        if (!string.IsNullOrEmpty(jsonData))
                        {
                            existingData = JsonConvert.DeserializeObject<List<LabelSettingData>>(jsonData);
                        }
                    }
                }

                existingData.AddRange(newData);
                string updatedJsonData = JsonConvert.SerializeObject(existingData);
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\SmlLabelChecker"))
                {
                    if (key != null)
                    {
                        key.SetValue("LabelSettingData", updatedJsonData, RegistryValueKind.String);
                    }
                }
            }
            catch (JsonException ex)
            {
                MessageBox.Show($"JSON 처리 오류: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"오류 발생: {ex.Message}");
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                int hospitalCode = Convert.ToInt32(HospitalTextBox.Text);
                int testCode = Convert.ToInt32(TestCodeTextBox.Text);
                int settingLabel = LabelSettingDrop.SelectedIndex == 0 ? 0 : LabelSettingDrop.SelectedIndex + 1;

                List<LabelSettingData> newData = new List<LabelSettingData>
                {
                    new LabelSettingData
                    {
                        HospitalCode = hospitalCode,
                        TestCode = testCode,
                        SettingLabel = settingLabel
                    }
                };

                SaveToRegistry(newData);
                RefreshDataView();

                HospitalTextBox.Text = "";
                TestCodeTextBox.Text = "";
                LabelSettingDrop.SelectedIndex = 0;
            }
            catch (FormatException)
            {
                MessageBox.Show("숫자를 입력해주세요.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"오류 발생: {ex.Message}");
            }
        }

        public void RefreshDataView(List<LabelSettingData> dataList = null)
        {
            try
            {
                if (dataList == null)
                {
                    using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\SmlLabelChecker"))
                    {
                        if (key != null)
                        {
                            string jsonData = key.GetValue("LabelSettingData")?.ToString();
                            if (!string.IsNullOrEmpty(jsonData))
                            {
                                dataList = JsonConvert.DeserializeObject<List<LabelSettingData>>(jsonData);
                            }
                        }
                    }
                }

                LabelSettingDataView.Items.Clear(); // 기존 항목 제거
                if (dataList != null && dataList.Count > 0)
                {
                    foreach (var data in dataList)
                    {
                        string message = data.SettingLabel == 0
                            ? $"{data.HospitalCode}병원에서는 {data.TestCode}코드의 검사를 진행 시, 라벨을 사용하지 않습니다."
                            : $"{data.HospitalCode}병원에서는 {data.TestCode}코드의 검사를 진행 시, 라벨을 {data.SettingLabel}개를 사용합니다.";
                        LabelSettingDataView.Items.Add(new ListBoxItem(data, message));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"데이터 뷰 갱신 오류: {ex.Message}");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (LabelSettingDataView.SelectedItem == null)
                {
                    MessageBox.Show("삭제할 항목을 선택해주세요.");
                    return;
                }

                var selectedItem = (ListBoxItem)LabelSettingDataView.SelectedItem;
                var selectedData = selectedItem.Data;

                List<LabelSettingData> existingData = new List<LabelSettingData>();
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\SmlLabelChecker"))
                {
                    if (key != null)
                    {
                        string jsonData = key.GetValue("LabelSettingData")?.ToString();
                        if (!string.IsNullOrEmpty(jsonData))
                        {
                            existingData = JsonConvert.DeserializeObject<List<LabelSettingData>>(jsonData);
                        }
                    }
                }

                var itemToRemove = existingData.Find(d =>
                    d.HospitalCode == selectedData.HospitalCode &&
                    d.TestCode == selectedData.TestCode &&
                    d.SettingLabel == selectedData.SettingLabel);

                if (itemToRemove != null)
                {
                    existingData.Remove(itemToRemove);
                    SaveToRegistry(existingData);
                    RefreshDataView();
                }
                else
                {
                    MessageBox.Show("삭제할 항목을 찾을 수 없습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"삭제 중 오류 발생: {ex.Message}");
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public class LabelSettingData
        {
            public int HospitalCode { get; set; }
            public int TestCode { get; set; }
            public int SettingLabel { get; set; }
        }

        public class ListBoxItem
        {
            public LabelSettingData Data { get; }
            public string DisplayText { get; }

            public ListBoxItem(LabelSettingData data, string displayText)
            {
                Data = data;
                DisplayText = displayText;
            }

            public override string ToString() => DisplayText;
        }
    }
}