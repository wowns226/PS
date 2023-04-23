#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/2447
 ***************************************************************************************/

using namespace std;

void func(int x, int y, int num) {
    if ((x / num) % 3 == 1 && (y / num) % 3 == 1) {
        cout << ' ';
    } else {
        if (num / 3 == 0) {
            cout << '*';
        } else {
            func(x, y, num / 3);
        }
    }
}

int main() {
    FASTIO;
    int n;
    cin >> n;
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < n; j++) {
            func(i, j, n);
        }
        cout << ENDL;
    }

    return 0;
}
