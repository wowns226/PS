ls = list(map(int, input().split()))
n=len(ls)
a=0
b=0

for i in range(0, n, 2):
    a += ls[i]

for i in range(1, n, 2):
    b += ls[i]

print(abs(a-b))
