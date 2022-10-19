#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL "\n"

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/17276
 ***************************************************************************************/

using namespace std;

int n, d, t;

int main() {
    FASTIO;
    cin >> t;

    while (t--) {
        int board[502][502] = {
            0,
        };
        int rotate_board[502][502] = {
            0,
        };
        cin >> n >> d;
        d /= 45;
        // 시계방향으로만 돌리기 위해 양수로 변환
        if (d < 0) {
            d += 8;
        }

        // n * n 배열
        for (int x = 0; x < n; x++) {
            for (int y = 0; y < n; y++) {
                cin >> board[x][y];
            }
        }

        // 1. X의 주 대각선을 ((1,1), (2,2), …, (n, n)) 가운데 열 ((n+1)/2 번째 열)로 옮긴다.
        // 2. X의 가운데 열을 X의 부 대각선으로 ((n, 1), (n-1, 2), …, (1, n)) 옮긴다.
        // 3. X의 부 대각선을 X의 가운데 행 ((n+1)/2번째 행)으로 옮긴다.
        // 4. X의 가운데 행을 X의 주 대각선으로 옮긴다.

        // d번 반복
        for (int k = 0; k < d; k++) {
            // 1
            for (int i = 0; i < n; i++) {
                rotate_board[i][n / 2] = board[i][i];
            }
            // 2
            for (int i = 0; i < n; i++) {
                rotate_board[n - i - 1][i] = board[n - i - 1][n / 2];
            }
            // 3
            for (int i = 0; i < n; i++) {
                rotate_board[n / 2][i] = board[n - i - 1][i];
            }
            // 4
            for (int i = 0; i < n; i++) {
                rotate_board[i][i] = board[n / 2][i];
            }

            for (int x = 0; x < n; x++) {
                for (int y = 0; y < n; y++) {
                    if (rotate_board[x][y] != 0) {
                        board[x][y] = rotate_board[x][y];
                    }
                }
            }
        }

        for (int x = 0; x < n; x++) {
            for (int y = 0; y < n; y++) {
                cout << board[x][y] << ' ';
            }
            cout << ENDL;
        }
    }

    return 0;
}
