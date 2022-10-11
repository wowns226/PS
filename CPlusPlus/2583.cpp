#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'
#define X first
#define Y second

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/2583
 ***************************************************************************************/

using namespace std;

int m, n, k;
pair<int, int> startPoint, endPoint;
bool board[102][102];
queue<pair<int, int>> q;
int dx[4] = {1, 0, -1, 0};
int dy[4] = {0, 1, 0, -1};
vector<int> answer;

void Make_Rect(pair<int, int> _start, pair<int, int> _end) {
    for (int x = _start.X; x < _end.X; x++) {
        for (int y = _start.Y; y < _end.Y; y++) {
            board[x][y] = true;
        }
    }
}

int main() {
    FASTIO;

    cin >> m >> n >> k;

    for (int x = 0; x < n; x++) {
        for (int y = 0; y < m; y++) {
            board[x][y] = false;
        }
    }

    while (k--) {
        cin >> startPoint.X >> startPoint.Y >> endPoint.X >> endPoint.Y;

        Make_Rect(startPoint, endPoint);
    }

    for (int x = 0; x < n; x++) {
        for (int y = 0; y < m; y++) {
            if (!board[x][y]) {
                int cnt = 0;
                q.push({x, y});
                board[x][y] = true;

                while (!q.empty()) {
                    auto cur = q.front();
                    q.pop();
                    cnt++;

                    for (int dir = 0; dir < 4; dir++) {
                        int nx = cur.X + dx[dir];
                        int ny = cur.Y + dy[dir];

                        if (nx < 0 || ny < 0 || nx >= n || ny >= m) continue;
                        if (board[nx][ny]) continue;

                        q.push({nx, ny});
                        board[nx][ny] = true;
                    }
                }

                answer.push_back(cnt);
            }
        }
    }

    sort(answer.begin(), answer.end());

    cout << answer.size() << ENDL;
    for (int i = 0; i < answer.size(); i++) {
        cout << answer[i] << ' ';
    }
    cout << ENDL;

    return 0;
}
