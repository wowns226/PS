#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/15683
 *   * 참고 : https://github.com/encrypted-def/basic-algo-lecture/blob/master/0x0D/solutions/15683.cpp
 ***************************************************************************************/

using namespace std;

const int MAX = 10;

int n, m, answer = 0;
int mainBoard[MAX][MAX];
int checkBoard[MAX][MAX];
int dx[4] = {1, 0, -1, 0};
int dy[4] = {0, 1, 0, -1};
vector<pair<int, int>> cctv;

void func(int x, int y, int dir) {
    dir %= 4;
    while (true) {
        x += dx[dir];
        y += dy[dir];

        // 범위를 벗어났을 때
        if (x < 0 || x >= n || y < 0 || y >= m) return;
        // 벽을 만났을 때
        if (checkBoard[x][y] == 6) return;
        // cctv가 있을때
        if (checkBoard[x][y] != 0) continue;

        checkBoard[x][y] = 7;
    }
}

int main() {
    FASTIO;
    cin >> n >> m;

    for (int i = 0; i < n; i++) {
        for (int j = 0; j < m; j++) {
            cin >> mainBoard[i][j];

            if (mainBoard[i][j] != 0 && mainBoard[i][j] != 6) {
                // cctv라면
                cctv.push_back({i, j});
            }
            if (mainBoard[i][j] == 0) {
                // 아무것도 아니라면
                answer++;
            }
        }
    }

    // 2^2 => 1<<2
    // 4^cctv.size() => 1<<2*cctv.size()
    for (int t = 0; t < (1 << (2 * cctv.size())); t++) {
        // checkBoard 원상복구
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                checkBoard[i][j] = mainBoard[i][j];
            }
        }

        int brute = t;
        for (int i = 0; i < cctv.size(); i++) {
            int dir = brute % 4;
            brute /= 4;

            // tie(x,y) = cctv[i];
            int x = cctv[i].first;
            int y = cctv[i].second;

            if (mainBoard[x][y] == 1) {
                func(x, y, dir);
            } else if (mainBoard[x][y] == 2) {
                func(x, y, dir);
                func(x, y, dir + 2);
            } else if (mainBoard[x][y] == 3) {
                func(x, y, dir);
                func(x, y, dir + 1);

            } else if (mainBoard[x][y] == 4) {
                func(x, y, dir);
                func(x, y, dir + 1);
                func(x, y, dir + 2);
            } else {  // mainBoard[x][y]==5
                func(x, y, dir);
                func(x, y, dir + 1);
                func(x, y, dir + 2);
                func(x, y, dir + 3);
            }
        }

        int tmp = 0;
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                tmp += (checkBoard[i][j] == 0);  // if(checkBoard[i][j]==0) tmp++;
            }
        }

        answer = min(answer, tmp);
    }

    cout << answer << ENDL;
    return 0;
}
