#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/1463
 ***************************************************************************************/

using namespace std;

int dist[1000005];
int n;

int main() {
    FASTIO;
    cin >> n;
    dist[1] = 0;
    for (int i = 2; i <= n; i++) {
        dist[i] = dist[i - 1] + 1;
        if (i % 2 == 0) dist[i] = min(dist[i], dist[i / 2] + 1);
        if (i % 3 == 0) dist[i] = min(dist[i], dist[i / 3] + 1);
    }
    cout << dist[n];
    return 0;
}
