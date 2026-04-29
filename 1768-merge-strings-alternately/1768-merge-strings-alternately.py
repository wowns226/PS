class Solution(object):
    def mergeAlternately(self, word1, word2):
        """
        :type word1: str
        :type word2: str
        :rtype: str
        """

        bigger = max(len(word1), len(word2))
        merged = []
        n = m = 0
        for i in range(bigger * 2):
            if i % 2 == 0:
                if n < len(word1):
                    merged.append(word1[n])
                    n += 1
            else:
                if m < len(word2):
                    merged.append(word2[m])
                    m += 1

        return ''.join(merged)
        