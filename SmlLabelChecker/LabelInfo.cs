using System;
using System.Collections.Generic;
using System.Linq;

namespace SmlLabelChecker
{
    public static class LabelInfo
    {
        public static int _start;
        public static int _end;
        private static Dictionary<int, int> _labels = new Dictionary<int, int>();

        public static int Find(int number)
        {
            if (_labels.TryGetValue(number, out var find))
            {
                return find;
            }

            return -1;
        }

        public static void Apply(int number, int useLabel)
        {
            _labels[number] = useLabel;
        }

        // 콜백으로 라벨 번호와 남은 개수를 오름차순으로 반환하는 메서드
        public static void Foreach(Action<int, int> callback)
        {
            // 키(라벨 번호)를 오름차순으로 정렬
            var sortedKeys = _labels.Keys.OrderBy(key => key);

            // 정렬된 키를 순회하며 콜백 호출
            foreach (int number in sortedKeys)
            {
                callback(number, _labels[number]);
            }
        }
    }
}