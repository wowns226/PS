#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/2667
 ***************************************************************************************/

using namespace std;

const int MAX = 27;

int dx[4] = {1, 0, -1, 0};
int dy[4] = {0, 1, 0, -1};
string board[MAX];
bool visited[MAX][MAX];
int n, cnt = 0;
queue<pair<int, int>> q;
vector<int> answer;

int main() {
    FASTIO;
    cin >> n;

    for (int i = 0; i < n; i++) {
        cin >> board[i];
    }

    for (int x = 0; x < n; x++) {
        for (int y = 0; y < n; y++) {
            if (board[x][y] == '1' && !visited[x][y]) {
                cnt = 0;
                q.push({x, y});
                visited[x][y] = true;
                cnt++;

                while (!q.empty()) {
                    auto cur = q.front();
                    q.pop();

                    for (int dir = 0; dir < 4; dir++) {
                        int nx = cur.first + dx[dir];
                        int ny = cur.second + dy[dir];

                        if (nx < 0 || nx >= n || ny < 0 || ny >= n) continue;
                        if (board[nx][ny] != '1' || visited[nx][ny]) continue;

                        q.push({nx, ny});
                        visited[nx][ny] = true;
                        cnt++;
                    }
                }

                answer.push_back(cnt);
            }
        }
    }

    sort(answer.begin(), answer.end());

    cout << answer.size() << ENDL;

    for (int i = 0; i < answer.size(); i++) {
        cout << answer[i] << ENDL;
    }

    return 0;
}