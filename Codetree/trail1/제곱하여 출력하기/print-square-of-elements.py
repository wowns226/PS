_n = input()
_list = list(map(int, input().split()))
new_list = []

new_list = [i ** 2 for i in _list]

for i in new_list:
    print(i, end=' ')
