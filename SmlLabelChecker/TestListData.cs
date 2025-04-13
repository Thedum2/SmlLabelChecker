using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace SmlLabelChecker
{
    public class TestListData
    {
        private static Dictionary<string, string> _testContainer = new Dictionary<string, string>();
        private static Trie _numberTrie = new Trie();
        private static Dictionary<string, List<Test>> _keywordIndex = new Dictionary<string, List<Test>>();

        public static void Init()
        {
            // JSON 로드 (리소스 기반)
            Assembly assembly = Assembly.GetExecutingAssembly();
            string resourceName = "SmlLabelChecker.json.test_items.json"; // 네임스페이스 맞게 설정 확인 필요

            try
            {
                using (var stream = assembly.GetManifestResourceStream(resourceName))
                {
                    if (stream == null)
                        throw new InvalidOperationException($"리소스 {resourceName}을 찾을 수 없습니다.");

                    using (var reader = new StreamReader(stream))
                    {
                        string jsonContent = reader.ReadToEnd();
                        _testContainer = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonContent);
                        BuildIndexes(); // 인덱스 구축
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"테스트 데이터 로드 실패: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _testContainer = new Dictionary<string, string>(); // 기본값으로 초기화
            }
        }

        private static void BuildIndexes()
        {
            foreach (var kvp in _testContainer)
            {
                if (int.TryParse(kvp.Key, out int testCode))
                {
                    string testName = kvp.Value ?? string.Empty;
                    var test = new Test { TestCode = testCode, TestName = testName };

                    // Trie에 숫자 코드 추가
                    _numberTrie.Insert(kvp.Key, test);

                    var keywords = testName.Split(new[] { ' ' }, StringSplitOptions.None)
                        .Where(s => !string.IsNullOrEmpty(s))
                        .ToArray();
                    
                    foreach (var keyword in keywords)
                    {
                        if (!_keywordIndex.ContainsKey(keyword))
                            _keywordIndex[keyword] = new List<Test>();
                        _keywordIndex[keyword].Add(test);
                    }
                }
                else
                {
                    // 유효하지 않은 키는 로그나 메시지로 처리 (WinForm 환경)
                    //MessageBox.Show($"유효하지 않은 테스트 코드: {kvp.Key}", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    continue;
                }
            }
        }
        
        public static List<Test> Search(string key)
        {
            if (string.IsNullOrEmpty(key))
                return new List<Test>();

            List<Test> results;

            if (int.TryParse(key, out int testCode))
            {
                // Trie에서 "key"로 시작하는 모든 항목 반환
                results = _numberTrie.GetItemsStartingWith(key)
                    .OrderBy(t => t.TestCode)
                    .ToList();
            }
            else
            {
                // 키워드 인덱스에서 검색
                results = _keywordIndex
                    .Where(kvp => kvp.Key.Contains(key))
                    .SelectMany(kvp => kvp.Value)
                    .Distinct() // 중복 제거
                    .OrderBy(t => t.TestName.StartsWith(key) ? 0 : 1)
                    .ThenBy(t => t.TestName)
                    .ToList();

                // 인덱스에 없는 경우 전체 검색 (보완)
                if (results.Count == 0)
                {
                    results = _testContainer
                        .Where(kvp => kvp.Value.Contains(key) || kvp.Key == key)
                        .Select(kvp => new Test { TestCode = int.Parse(kvp.Key), TestName = kvp.Value })
                        .OrderBy(t => t.TestName.StartsWith(key) ? 0 : 1)
                        .ThenBy(t => t.TestName)
                        .ToList();
                }
            }

            return results;
        }

        public class Test
        {
            public int TestCode { get; set; }
            public string TestName { get; set; }
        }
    }

    // Trie 구현 (Test 타입으로 통일)
    public class Trie
    {
        private class TrieNode
        {
            public Dictionary<char, TrieNode> Children = new Dictionary<char, TrieNode>();
            public List<TestListData.Test> Items = new List<TestListData.Test>();
        }

        private TrieNode root = new TrieNode();

        public void Insert(string key, TestListData.Test item)
        {
            var node = root;
            foreach (char c in key)
            {
                if (!node.Children.ContainsKey(c))
                    node.Children[c] = new TrieNode();
                node = node.Children[c];
                node.Items.Add(item); // 모든 접두사에 항목 저장
            }
        }

        public List<TestListData.Test> GetItemsStartingWith(string prefix)
        {
            var node = root;
            foreach (char c in prefix)
            {
                if (!node.Children.ContainsKey(c))
                    return new List<TestListData.Test>();
                node = node.Children[c];
            }
            return node.Items;
        }
    }
}