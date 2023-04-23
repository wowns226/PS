#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/1926
 ***************************************************************************************/

using namespace std;

const int MAX = 502;

int n, m;
int board[MAX][MAX];
bool visited[MAX][MAX];
int dx[4] = {1, 0, -1, 0};
int dy[4] = {0, 1, 0, -1};

int main() {
    FASTIO;

    cin >> n >> m;

    for (int row = 0; row < n; row++) {
        for (int cal = 0; cal < m; cal++) {
            cin >> board[row][cal];
        }
    }

    int pictureMax = 0;
    int pictureCnt = 0;

    for (int row = 0; row < n; row++) {
        for (int cal = 0; cal < m; cal++) {
            if (board[row][cal] == 0 || visited[row][cal]) continue;
            pictureCnt++;
            queue<pair<int, int>> q;
            visited[row][cal] = true;
            q.push({row, cal});

            int area = 0;
            while (!q.empty()) {
                area++;
                pair<int, int> cur = q.front();
                q.pop();

                for (int dir = 0; dir < 4; dir++) {
                    int nx = cur.first + dx[dir];
                    int ny = cur.second + dy[dir];

                    if (nx < 0 || nx >= n || ny < 0 || ny >= m) continue;
                    if (visited[nx][ny] || board[nx][ny] != 1) continue;

                    visited[nx][ny] = true;
                    q.push({nx, ny});
                }
            }
            pictureMax = max(pictureMax, area);
        }
    }

    cout << pictureCnt << ENDL << pictureMax;

    return 0;
}
