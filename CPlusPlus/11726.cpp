#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/11726
 ***************************************************************************************/

using namespace std;

int n;
int arr[1005];

int main() {
    FASTIO;
    cin >> n;

    arr[1] = 1;
    arr[2] = 2;

    for (int i = 3; i <= n; i++) {
        arr[i] = (arr[i - 2] + arr[i - 1]) % 10007;
    }

    cout << arr[n] << ENDL;

    return 0;
}
