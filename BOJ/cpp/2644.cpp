#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL "\n"

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/2644
 ***************************************************************************************/

using namespace std;

const int MAX = 102;

int n, m, x, y, start_idx, end_idx;
bool board[MAX][MAX];
int visited[MAX];
queue<int> q;

int main() {
    FASTIO;

    cin >> n;
    cin >> start_idx >> end_idx;
    cin >> m;
    for (int i = 0; i < m; i++) {
        cin >> x >> y;

        board[x][y] = true;
        board[y][x] = true;
    }

    q.push(start_idx);

    while (!q.empty()) {
        auto cur = q.front();
        q.pop();

        for (int i = 0; i <= n; i++) {
            if (board[cur][i] && visited[i] == 0) {
                // i번째와 연결되어있고 방문한적이없으면
                q.push(i);
                visited[i] = visited[cur] + 1;
            }
        }
    }

    if (visited[end_idx] == 0) {
        visited[end_idx] = -1;
    }

    cout << visited[end_idx] << ENDL;

    return 0;
}
