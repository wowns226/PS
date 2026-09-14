ls = list(map(int, input().split()))

ans = 0
n = len(ls)
idx = 0
for i in range(n-1, 0, -1):
    if ls[i] == 0:
        idx = i

ans = ls[idx-1] + ls[idx-2] + ls[idx-3]

print(ans)