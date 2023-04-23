#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/9663
 ***************************************************************************************/

using namespace std;

const int MAX = 40;

bool isUsed1[MAX];
bool isUsed2[MAX];
bool isUsed3[MAX];
int n, cnt = 0;

void func(int cur) {
    if (cur == n) {
        cnt++;
        return;
    }

    for (int i = 0; i < n; i++) {
        if (isUsed1[i] || isUsed2[i + cur] || isUsed3[cur - i + n - 1]) continue;
        isUsed1[i] = 1;
        isUsed2[i + cur] = 1;
        isUsed3[cur - i + n - 1] = 1;
        func(cur + 1);
        isUsed1[i] = 0;
        isUsed2[i + cur] = 0;
        isUsed3[cur - i + n - 1] = 0;
    }
}

int main() {
    FASTIO;

    cin >> n;
    func(0);
    cout << cnt;

    return 0;
}
