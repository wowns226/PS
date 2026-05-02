class Solution(object):
    def kidsWithCandies(self, candies, extraCandies):
        """
        :type candies: List[int]
        :type extraCandies: int
        :rtype: List[bool]
        """
        ret = []

        # 현재 가장 많은 사탕 개수
        my_max = max(candies)

        for candy in candies:
            # extraCandies를 더했을 때 최대값 이상이면 True
            if candy + extraCandies >= my_max:
                ret.append(True)
            else:
                ret.append(False)

        return ret