#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

/***************************************************************************************
 *   * 링크 : https://school.programmers.co.kr/learn/courses/30/lessons/1844
 ***************************************************************************************/

using namespace std;

int solution(vector<vector<int>> maps) {
    int answer = 0;
    bool isVisited[102][102];

    int x = maps.size();
    int y = maps[0].size();

    for (int i = 0; i < x; i++) {
        for (int j = 0; j < y; j++) {
            if (maps[i][j] == 0) {
                isVisited[i][j] = true;
            } else {
                isVisited[i][j] = false;
            }
        }
    }

    queue<pair<int, int>> q;
    int dx[4] = {1, 0, -1, 0};
    int dy[4] = {0, 1, 0, -1};
    pair<int, int> target = {x - 1, y - 1};
    bool isEscape = false;

    q.push({0, 0});
    isVisited[0][0] = true;

    while (!q.empty()) {
        auto cur = q.front();

        if (cur == target) {
            isEscape = true;
            break;
        }

        q.pop();
        for (int dir = 0; dir < 4; dir++) {
            int nx = cur.first + dx[dir];
            int ny = cur.second + dy[dir];

            if (nx < 0 || ny < 0 || nx >= x || ny >= y) continue;
            if (maps[nx][ny] == 0 || isVisited[nx][ny]) continue;

            maps[nx][ny] = maps[cur.first][cur.second] + 1;
            q.push({nx, ny});
            isVisited[nx][ny] = true;
        }
    }

    if (isEscape) return maps[x - 1][y - 1];
    return -1;
}

int main() {
    FASTIO;

    vector<vector<int>> maps;

    maps.push_back({1, 0, 1, 1, 1});
    maps.push_back({1, 0, 1, 0, 1});
    maps.push_back({1, 0, 1, 1, 1});
    maps.push_back({1, 1, 1, 0, 1});
    maps.push_back({0, 0, 0, 0, 1});

    cout << solution(maps) << ENDL;

    return 0;
}
