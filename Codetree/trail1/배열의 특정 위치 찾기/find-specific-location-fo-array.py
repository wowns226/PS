ls = list(map(int, input().split()))

v_sum = 0
for i in range(1, len(ls), 2):
    v_sum += ls[i]

v_avg = 0
v_cnt = 0
for i in range(2, len(ls), 3):
    v_avg += ls[i]
    v_cnt += 1

print(f'{v_sum} {v_avg / v_cnt:.1f}')