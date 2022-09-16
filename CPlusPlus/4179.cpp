#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/4179
 ***************************************************************************************/

using namespace std;

const int MAX = 1002;

int R, C;
string board[MAX];
int dist1[MAX][MAX];  // 불
int dist2[MAX][MAX];  // 지훈
int dx[4] = {1, 0, -1, 0};
int dy[4] = {0, 1, 0, -1};

int main() {
    FASTIO;

    cin >> R >> C;

    for (int i = 0; i < R; i++) {
        fill(dist1[i], dist1[i] + C, -1);
        fill(dist2[i], dist2[i] + C, -1);
    }

    for (int i = 0; i < R; i++) {
        cin >> board[i];
    }

    queue<pair<int, int>> q1;  // 불
    queue<pair<int, int>> q2;  // 지훈

    for (int i = 0; i < R; i++) {
        for (int j = 0; j < C; j++) {
            if (board[i][j] == 'F') {
                q1.push({i, j});
                dist1[i][j] = 0;
            }

            if (board[i][j] == 'J') {
                q2.push({i, j});
                dist2[i][j] = 0;
            }
        }
    }

    // 불
    while (!q1.empty()) {
        auto cur = q1.front();
        q1.pop();

        for (int dir = 0; dir < 4; dir++) {
            int nx = cur.first + dx[dir];
            int ny = cur.second + dy[dir];

            if (nx < 0 || nx >= R || ny < 0 || ny >= C) continue;
            if (dist1[nx][ny] >= 0 || board[nx][ny] == '#') continue;

            dist1[nx][ny] = dist1[cur.first][cur.second] + 1;
            q1.push({nx, ny});
        }
    }

    // 지훈
    while (!q2.empty()) {
        auto cur = q2.front();
        q2.pop();

        for (int dir = 0; dir < 4; dir++) {
            int nx = cur.first + dx[dir];
            int ny = cur.second + dy[dir];

            if (nx < 0 || nx >= R || ny < 0 || ny >= C) {
                cout << dist2[cur.first][cur.second] + 1 << ENDL;
                return 0;
            }
            if (dist2[nx][ny] >= 0 || board[nx][ny] == '#') continue;
            if (dist1[nx][ny] != -1 && dist1[nx][ny] <= dist2[cur.first][cur.second] + 1) continue;

            dist2[nx][ny] = dist2[cur.first][cur.second] + 1;
            q2.push({nx, ny});
        }
    }
    cout << "IMPOSSIBLE" << ENDL;

    return 0;
}
