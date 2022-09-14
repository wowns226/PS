#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL "\n"

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/1074
 ***************************************************************************************/

using namespace std;

int func(int n, int r, int c) {
    if (n == 0) return 0;
    int half = 1 << (n - 1);
    if (r < half && c < half) return func(n - 1, r, c);
    if (r < half && c >= half) return half * half + func(n - 1, r, c - half);
    if (r >= half && c < half) return 2 * half * half + func(n - 1, r - half, c);
    return 3 * half * half + func(n - 1, r - half, c - half);
}

int main() {
    FASTIO;

    int n, r, c;
    cin >> n >> r >> c;
    cout << func(n, r, c) << ENDL;

    return 0;
}
