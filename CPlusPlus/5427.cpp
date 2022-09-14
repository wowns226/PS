#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL "\n"

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/5427
 ***************************************************************************************/

using namespace std;

const int MAX = 1002;

char board[MAX][MAX];
int dist1[MAX][MAX];  // 불
int dist2[MAX][MAX];  // 상근
int dx[4] = {1, 0, -1, 0};
int dy[4] = {0, 1, 0, -1};
int testCase, w, h;

void bfs() {
    queue<pair<int, int>> q1;  // 불
    queue<pair<int, int>> q2;  // 상근

    memset(board, ' ', sizeof(board));
    memset(dist1, -1, sizeof(dist1));
    memset(dist2, -1, sizeof(dist2));

    cin >> w >> h;

    for (int x = 0; x < w; x++) {
        for (int y = 0; y < h; y++) {
            cin >> board[x][y];

            if (board[x][y] == '*') {
                q1.push({x, y});
                dist1[x][y] = 0;
            }
            if (board[x][y] == '@') {
                q2.push({x, y});
                dist2[x][y] = 0;
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

            if (nx < 0 || ny < 0 || nx >= w || ny >= h) continue;
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

            if (nx < 0 || ny < 0 || nx >= w || ny >= h) {
                cout << dist2[cur.first][cur.second] + 1 << ENDL;
                return;
            }
            if (dist2[nx][ny] >= 0 || board[nx][ny] == '#') continue;
            if (dist2[nx][ny] != -1 && dist1[nx][ny] <= dist2[cur.first][cur.second] + 1) continue;

            dist2[nx][ny] = dist2[cur.first][cur.second] + 1;
            q2.push({nx, ny});
        }
    }

    cout << "IMPOSSIBLE" << ENDL;
    return;
}

int main() {
    FASTIO;

    cin >> testCase;

    for (int t = 0; t < testCase; t++) {
        bfs();
    }

    return 0;
}