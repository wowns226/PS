#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/2448
 ***************************************************************************************/

using namespace std;

char board[3072][6143];

void star(int x, int y) {
    board[x][y] = '*';

    board[x + 1][y - 1] = '*';
    board[x + 1][y + 1] = '*';

    for (int t = 0; t < 5; t++) {
        board[x + 2][y - 2 + t] = '*';
    }
}

void func(int x, int y, int num) {
    if (num == 3) {
        star(x, y);
        return;
    }

    func(x, y, num / 2);
    func(x + num / 2, y - num / 2, num / 2);
    func(x + num / 2, y + num / 2, num / 2);
}

int main() {
    FASTIO;
    int n;
    cin >> n;

    for (int i = 0; i < n; i++) {
        for (int j = 0; j < n * 2 - 1; j++) {
            board[i][j] = ' ';
        }
    }

    func(0, n - 1, n);

    for (int i = 0; i < n; i++) {
        for (int j = 0; j < n * 2 - 1; j++) {
            cout << board[i][j];
        }
        cout << ENDL;
    }
    return 0;
}
