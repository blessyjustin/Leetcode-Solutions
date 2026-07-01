class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        hashmap={}
        for words in strs:
            count=[0]*26
            for ch in words:
                count[ord(ch)-ord('a')]+=1
            keys=tuple(count)
            if keys not in hashmap:
                hashmap[keys]=[]
            hashmap[keys].append(words)
        return list(hashmap.values())