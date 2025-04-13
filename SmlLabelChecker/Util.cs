using System;
using System.Collections.Generic;

namespace SmlLabelChecker
{
    public class Util
    {
        public static (int year, int month, int day) ParseDateToTuple(string dateStr)
        {
            if (dateStr.Length != 8 || !int.TryParse(dateStr, out _))
            {
                throw new ArgumentException("날짜는 8자리 숫자 형식이어야 합니다. (예: 20251026)");
            }

            int year = int.Parse(dateStr.Substring(0, 4));  // 첫 4자리: 년
            int month = int.Parse(dateStr.Substring(4, 2));  // 다음 2자리: 월
            int day = int.Parse(dateStr.Substring(6, 2));    // 마지막 2자리: 일

            // 유효성 검사 (간단히)
            if (month < 1 || month > 12 || day < 1 || day > 31)
            {
                throw new ArgumentException("유효하지 않은 월 또는 일입니다.");
            }

            return (year, month, day);
        }

        // 튜플을 "접수일자: YYYY/MM/DD" 형식으로 변환하는 함수
        public static string FormatDateString((int year, int month, int day) dateTuple)
        {
            return $"접수일자: {dateTuple.year}/{dateTuple.month:D2}/{dateTuple.day:D2}";
        }

        public static string FormatEtcText(List<string> stringList)
        {
            if (stringList == null || stringList.Count == 0)
                return string.Empty;

            return string.Join("\n", stringList);
        }
    }
}