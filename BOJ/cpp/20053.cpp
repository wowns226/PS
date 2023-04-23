#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/20053
 ***************************************************************************************/

using namespace std;

int t, n;
vector<int> v;

int main() {
    FASTIO;
    cin >> t;
    while (t--) {
        cin >> n;
        for (int i = 0; i < n; i++) {
            int tmp;
            cin >> tmp;
            v.push_back(tmp);
        }

        sort(v.begin(), v.end());

        cout << v.front() << ' ' << v.back() << ENDL;

        v.clear();
    }

    return 0;
}
