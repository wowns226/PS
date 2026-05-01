class Solution:
    def gcdOfStrings(self, str1: str, str2: str) -> str:
        # 두 문자열을 서로 다른 순서로 붙였을 때 결과가 다르면
        # 공통으로 반복되는 문자열 x가 존재할 수 없음
        # 예: "ABAB" + "AB" == "AB" + "ABAB" → 가능
        # 예: "LEET" + "CODE" != "CODE" + "LEET" → 불가능
        if str1 + str2 != str2 + str1:
            return ""

        # 유클리드 호제법
        # 문자열 길이의 최대공약수를 구하는 함수
        def gcd(a: int, b: int) -> int:
            while b != 0:
                a, b = b, a % b

            return a

        # str1과 str2 길이의 최대공약수 구하기
        gcd_length = gcd(len(str1), len(str2))

        # 공통으로 나눌 수 있는 가장 긴 문자열은
        # str1의 앞에서부터 gcd_length만큼 자른 문자열
        return str1[:gcd_length]