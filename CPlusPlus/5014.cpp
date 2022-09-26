#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL "\n"

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/5014
 ***************************************************************************************/

using namespace std;

int F, S, G, U, D;
vector<int> v;
vector<bool> visited;
queue<int> q;

int main() {
    FASTIO;
    cin >> F >> S >> G >> U >> D;

    v.resize(F + 1, 0);
    visited.resize(F + 1, false);

    if (S == G) {
        cout << 0 << ENDL;
        return 0;
    }

    visited[S] = true;
    q.push(S);

    while (!q.empty()) {
        auto cur = q.front();
        if (cur == G) break;
        q.pop();

        if (cur + U <= F && !visited[cur + U]) {
            v[cur + U] = v[cur] + 1;
            visited[cur + U] = true;
            q.push(cur + U);
        }

        if (cur - D > 0 && !visited[cur - D]) {
            v[cur - D] = v[cur] + 1;
            visited[cur - D] = true;
            q.push(cur - D);
        }
    }

    if (visited[G] == false) {
        cout << "use the stairs" << ENDL;
    } else {
        cout << v[G] << ENDL;
    }

    return 0;
}
