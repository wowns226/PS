#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/18808
 *   * 참고 : https://github.com/encrypted-def/basic-algo-lecture/blob/master/0x0D/solutions/18808.cpp
 ***************************************************************************************/

using namespace std;

int n, m, k, r, c;
int board[42][42];
int sticker[12][12];

// sticker 90도 회전 함수
void rotate() {
    int tmp[12][12];

    for (int i = 0; i < r; i++) {
        for (int j = 0; j < c; j++) {
            tmp[i][j] = sticker[i][j];
        }
    }

    for (int i = 0; i < c; i++) {
        for (int j = 0; j < r; j++) {
            sticker[i][j] = tmp[r - 1 - j][i];
        }
    }

    swap(r, c);
}

// board의 좌표(x,y)에 스티커 (0,0)이 올라가게 스티커를 붙일 수 있는지 판단
// 가능할 경우 board를 갱신한 후 true를 반환
bool pastable(int x, int y) {
    for (int i = 0; i < r; i++) {
        for (int j = 0; j < c; j++) {
            if (board[x + i][y + j] == 1 && sticker[i][j] == 1) {
                return false;
            }
        }
    }

    for (int i = 0; i < r; i++) {
        for (int j = 0; j < c; j++) {
            if (sticker[i][j] == 1) {
                board[x + i][y + j] = 1;
            }
        }
    }

    return true;
}

int main() {
    FASTIO;
    cin >> n >> m >> k;
    while (k--) {
        cin >> r >> c;
        for (int i = 0; i < r; i++) {
            for (int j = 0; j < c; j++) {
                cin >> sticker[i][j];
            }
        }

        for (int rot = 0; rot < 4; rot++) {
            bool isPaste = false;  // 스티커 붙이기 여부 판단
            for (int x = 0; x <= n - r; x++) {
                if (isPaste) {
                    break;
                }
                for (int y = 0; y <= m - c; y++) {
                    if (pastable(x, y)) {
                        isPaste = true;
                        break;
                    }
                }
            }
            if (isPaste) {
                break;
            }
            rotate();
        }
    }

    int cnt = 0;
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < m; j++) {
            cnt += board[i][j];
        }
    }
    cout << cnt << ENDL;
    return 0;
}
