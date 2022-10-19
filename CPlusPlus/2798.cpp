#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/2798
 ***************************************************************************************/

using namespace std;

int n, m, sum = 0, answer = 0;
vector<int> v;

int main() {
    FASTIO;
    cin >> n >> m;

    for (int i = 0; i < n; i++) {
        int tmp = 0;
        cin >> tmp;
        v.push_back(tmp);
    }

    for (int i = 0; i < n; i++) {
        for (int j = i + 1; j < n; j++) {
            for (int k = j + 1; k < n; k++) {
                sum = (v[i] + v[j] + v[k]);

                if (sum <= m) {
                    answer = max(answer, sum);
                }
            }
        }
    }

    cout << answer << ENDL;

    return 0;
}
