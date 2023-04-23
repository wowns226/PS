#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'
#define ll long long

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/1629
 ***************************************************************************************/

using namespace std;

ll POW(int a, int b, int c) {
    if (b == 1) return a % c;
    ll val = POW(a, b / 2, c);
    val = val * val % c;
    if (b % 2 == 0) return val;
    return val * a % c;
}
int main() {
    FASTIO;

    int A, B, C;
    cin >> A >> B >> C;

    cout << POW(A, B, C) << ENDL;

    return 0;
}
