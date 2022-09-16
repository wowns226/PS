#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/2630
 ***************************************************************************************/

using namespace std;

const int MAX = 130;

int n, white = 0, blue = 0;
int board[MAX][MAX];

void func(int x, int y, int n) {
    bool isSame = true;
    for (int i = x; i < x + n; i++) {
        for (int j = y; j < y + n; j++) {
            if (board[i][j] != board[x][y]) {
                isSame = false;
                break;
            }
        }
        if (!isSame) {
            break;
        }
    }

    if (isSame) {
        if (board[x][y] == 0) {
            white++;
        } else if (board[x][y] == 1) {
            blue++;
        }
    } else {
        func(x, y, n / 2);                  // 1
        func(x + n / 2, y, n / 2);          // 2
        func(x, y + n / 2, n / 2);          // 3
        func(x + n / 2, y + n / 2, n / 2);  // 4
    }
}

int main() {
    FASTIO;
    cin >> n;
    for (int x = 0; x < n; x++) {
        for (int y = 0; y < n; y++) {
            cin >> board[x][y];
        }
    }

    func(0, 0, n);

    cout << white << ENDL;
    cout << blue << ENDL;

    return 0;
}
