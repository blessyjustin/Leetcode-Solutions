public class Solution {
    public IList<int> FindSubstring(string s, string[] words) {
        IList<int> result=new List<int>();
        int wordlen=words[0].Length;
        int wordCount=words.Length;

        Dictionary<string,int> required=new Dictionary<string,int>();
        foreach(string word in words)
        {
            if(required.ContainsKey(word))
            {
                required[word]++;
            }
            else{
                required[word]=1;
            }
        }

        for (int offset=0; offset<wordlen;offset++)
        {
            int left=offset;
            int count=0;
            Dictionary<string,int> current=new Dictionary<string,int>();
            for(int right=offset;right+wordlen<=s.Length;right+=wordlen)
            {
                string word=s.Substring(right,wordlen);
                if(!required.ContainsKey(word))
                {
                    current.Clear();
                    count=0;
                    left=right+wordlen;
                    continue;
                }

                if(current.ContainsKey(word))
                {
                    current[word]++;
                }
                else
                {
                    current[word]=1;
                }

                count++;

                while(current[word]>required[word])
                {
                    string leftword=s.Substring(left,wordlen);
                    current[leftword]--;
                    left+=wordlen;
                    count--;
                }

                if(count==wordCount)
                {
                    result.Add(left);
                    string leftword=s.Substring(left,wordlen);
                    current[leftword]--;
                    left+=wordlen;
                    count--;
                }
            }
        }

        return result;


    }
}