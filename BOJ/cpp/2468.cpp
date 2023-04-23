#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL "\n"

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/2468
 ***************************************************************************************/

using namespace std;

const int MAX = 102;

int board[MAX][MAX];
int n, height_max, height_min = 100;
bool visited[MAX][MAX];
queue<pair<int, int>> q;
int dx[4] = {1, 0, -1, 0};
int dy[4] = {0, 1, 0, -1};

int main() {
    FASTIO;

    cin >> n;

    for (int x = 0; x < n; x++) {
        for (int y = 0; y < n; y++) {
            cin >> board[x][y];
            // 6 8 2 6 2
            // 3 2 3 4 6
            // 6 7 3 3 2
            // 7 2 5 3 6
            // 8 9 5 2 7
            height_max = max(height_max, board[x][y]);
            // 9
            height_min = min(height_min, board[x][y]);
            // 2
        }
    }

    int result = 0;
    for (int i = height_min - 1; i <= height_max; i++) {
        memset(visited, false, sizeof(visited));
        int cnt = 0;
        for (int x = 0; x < n; x++) {
            for (int y = 0; y < n; y++) {
                if (board[x][y] <= i) {
                    visited[x][y] = true;
                }
            }
        }

        for (int x = 0; x < n; x++) {
            for (int y = 0; y < n; y++) {
                if (!visited[x][y]) {
                    q.push({x, y});
                    visited[x][y] = true;

                    cnt++;
                }

                while (!q.empty()) {
                    auto cur = q.front();
                    q.pop();

                    for (int dir = 0; dir < 4; dir++) {
                        int nx = cur.first + dx[dir];
                        int ny = cur.second + dy[dir];

                        if (nx < 0 || nx >= n || ny < 0 || ny >= n) continue;
                        if (visited[nx][ny]) continue;

                        q.push({nx, ny});
                        visited[nx][ny] = true;
                    }
                }
            }
        }

        result = max(cnt, result);
    }
    cout << result << ENDL;

    return 0;
}