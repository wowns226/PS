#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/6118
 ***************************************************************************************/

using namespace std;

int n, m, a, b = 0, cnt;
vector<int> v[20002];
int visited[20002];
queue<int> q;

int main() {
    FASTIO;

    cin >> n >> m;
    for (int i = 0; i < m; i++) {
        int x, y;
        cin >> x >> y;

        v[x].push_back(y);
        v[y].push_back(x);
    }

    visited[1] = 1;
    q.push(1);

    while (!q.empty()) {
        // 현재 위치를 cur에 저장
        auto cur = q.front();
        q.pop();

        for (int i = 0; i < v[cur].size(); i++) {
            // 방문했다면 패스
            if (visited[v[cur][i]]) continue;

            // cur의 값보다 + 1
            visited[v[cur][i]] = visited[cur] + 1;

            // 가장 큰 값을 저장
            b = max(visited[v[cur][i]], b);

            // 현재 위치를 q에 삽입
            q.push(v[cur][i]);
        }
    }

    // 최소값을 찾는 반복문
    for (int i = 1; i <= n; i++) {
        // 최소값을 찾았으면 해당 인덱스 저장 후 함수 break
        if (b == visited[i]) {
            a = i;
            break;
        }
    }

    // 같은 거리의 개수를 찾는 반복문
    for (int i = 1; i <= n; i++) {
        // 같은 거리라면 cnt를 증가시킴
        if (b == visited[i]) {
            cnt++;
        }
    }

    cout << a << ' ' << b - 1 << ' ' << cnt;

    return 0;
}
