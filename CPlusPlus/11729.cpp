#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL "\n"

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/11729
 ***************************************************************************************/

using namespace std;

void hanoi(int a, int b, int n) {
    if (n == 1) {
        cout << a << ' ' << b << ENDL;
        return;
    }

    hanoi(a, 6 - a - b, n - 1);
    cout << a << ' ' << b << ENDL;
    hanoi(6 - a - b, b, n - 1);
}

int main() {
    FASTIO;

    int k;
    cin >> k;
    cout << (1 << k) - 1 << ENDL;

    hanoi(1, 3, k);

    return 0;
}
