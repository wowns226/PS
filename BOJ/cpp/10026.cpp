#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/10026
 ***************************************************************************************/

using namespace std;

const int MAX = 102;

string board[MAX];
int N, answer1 = 0, answer2 = 0;
bool visited1[MAX][MAX];
bool visited2[MAX][MAX];
int dx[4] = {1, 0, -1, 0};
int dy[4] = {0, 1, 0, -1};
queue<pair<int, int>> q1;
queue<pair<int, int>> q2;

int main() {
    FASTIO;

    cin >> N;
    for (int i = 0; i < N; i++) {
        cin >> board[i];
    }

    for (int i = 0; i < N; i++) {
        for (int j = 0; j < N; j++) {
            if (!visited1[i][j]) {
                answer1++;

                q1.push({i, j});

                while (!q1.empty()) {
                    auto cur = q1.front();
                    q1.pop();

                    for (int dir = 0; dir < 4; dir++) {
                        int nx = cur.first + dx[dir];
                        int ny = cur.second + dy[dir];

                        if (nx < 0 || nx >= N || ny < 0 || ny >= N) continue;
                        if (board[cur.first][cur.second] != board[nx][ny]) continue;
                        if (visited1[nx][ny]) continue;

                        q1.push({nx, ny});
                        visited1[nx][ny] = true;
                    }
                }
            }
        }
    }

    for (int i = 0; i < N; i++) {
        for (int j = 0; j < N; j++) {
            if (board[i][j] == 'G') board[i][j] = 'R';
        }
    }

    for (int i = 0; i < N; i++) {
        for (int j = 0; j < N; j++) {
            if (!visited2[i][j]) {
                answer2++;

                q2.push({i, j});

                while (!q2.empty()) {
                    auto cur = q2.front();
                    q2.pop();

                    for (int dir = 0; dir < 4; dir++) {
                        int nx = cur.first + dx[dir];
                        int ny = cur.second + dy[dir];

                        if (nx < 0 || nx >= N || ny < 0 || ny >= N) continue;
                        if (board[cur.first][cur.second] != board[nx][ny]) continue;
                        if (visited2[nx][ny]) continue;

                        q2.push({nx, ny});
                        visited2[nx][ny] = true;
                    }
                }
            }
        }
    }

    cout << answer1 << ' ' << answer2 << ENDL;

    return 0;
}
