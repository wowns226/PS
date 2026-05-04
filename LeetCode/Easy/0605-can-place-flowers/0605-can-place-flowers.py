class Solution(object):
    def canPlaceFlowers(self, flowerbed, n):
        """
        :type flowerbed: List[int]
        :type n: int
        :rtype: bool
        """
        # 심을 꽃이 0개라면 바로 가능
        if n == 0:
            return True

        # 화단을 앞에서부터 하나씩 확인
        for i in range(len(flowerbed)):

            # 현재 자리 비어있는지 체크
            if flowerbed[i] == 1:
                continue

            # 왼쪽 자리 비어있는지 체크
            left_empty = (i == 0 or flowerbed[i - 1] == 0)

            # 오른쪽 자리 비어있는지 체크
            right_empty = (i == len(flowerbed) - 1 or flowerbed[i + 1] == 0)

            # 현재 칸, 왼쪽 칸, 오른쪽 칸이 모두 조건을 만족하면 심기 가능
            if left_empty and right_empty:
                flowerbed[i] = 1   # 꽃을 심었다고 표시
                n -= 1             # 심어야 할 꽃 개수 감소

                # 다 소모한 경우
                if n == 0:
                    return True

        # 다 소모하지 못한 경우
        return False