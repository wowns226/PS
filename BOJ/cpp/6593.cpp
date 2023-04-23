#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL "\n"

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/6593
 ***************************************************************************************/

using namespace std;

const int MAX = 32;

int l, r, c;
int board[MAX][MAX][MAX];
bool isVisited[MAX][MAX][MAX];

int dx[6] = {1, 0, 0, -1, 0, 0};
int dy[6] = {0, 1, 0, 0, -1, 0};
int dz[6] = {0, 0, 1, 0, 0, -1};
queue<pair<pair<int, int>, int>> q;
pair<pair<int, int>, int> target;
bool isEscape;

int main() {
    FASTIO;

    while (true) {
        cin >> l >> r >> c;

        if (l == 0 && r == 0 && c == 0) {
            // 0 0 0 입력시 프로그램 종료
            return 0;
        }

        memset(board, 0, sizeof(board));
        memset(isVisited, false, sizeof(isVisited));

        while (!q.empty()) {
            q.pop();
        }
        isEscape = false;

        for (int z = 0; z < l; z++) {
            for (int y = 0; y < r; y++) {
                string s;
                cin >> s;
                for (int x = 0; x < c; x++) {
                    if (s[x] == '.') {
                        board[x][y][z] = 0;
                    } else if (s[x] == '#') {
                        board[x][y][z] = -1;
                        isVisited[x][y][z] = true;
                    } else if (s[x] == 'E') {
                        target = {{x, y}, z};
                    } else if (s[x] == 'S') {
                        q.push({{x, y}, z});
                        isVisited[x][y][z] = true;
                    }
                }
            }
        }

        while (!q.empty()) {
            auto cur = q.front();
            q.pop();

            if (cur == target) {
                cout << "Escaped in " << board[cur.first.first][cur.first.second][cur.second] << " minute(s)." << ENDL;
                isEscape = true;
                break;
            }

            for (int dir = 0; dir < 6; dir++) {
                int nx = cur.first.first + dx[dir];
                int ny = cur.first.second + dy[dir];
                int nz = cur.second + dz[dir];

                if (nx < 0 || ny < 0 || nz < 0 || nx >= c || ny >= r || nz >= l) continue;
                if (board[nx][ny][nz] == -1 || isVisited[nx][ny][nz]) continue;

                q.push({{nx, ny}, nz});
                isVisited[nx][ny][nz] = true;
                board[nx][ny][nz] = board[cur.first.first][cur.first.second][cur.second] + 1;
            }
        }

        if (!isEscape) {
            cout << "Trapped!" << ENDL;
        }
    }
}
