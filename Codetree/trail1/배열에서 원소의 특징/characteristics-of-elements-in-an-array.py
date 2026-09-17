ls = list(map(int, input().split()))
n = len(ls)

for i in range(0, n):
    if ls[i] % 3 == 0:
        print(ls[i-1])
        break