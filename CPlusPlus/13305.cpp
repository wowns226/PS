#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'
#define ll long long

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/13305
 ***************************************************************************************/

using namespace std;

int cityNum;
vector<ll> city;
vector<ll> dist;

int main() {
    FASTIO;
    cin >> cityNum;
    for (int i = 1; i < cityNum; i++) {
        int tmp;
        cin >> tmp;
        dist.push_back(tmp);
    }

    for (int i = 0; i < cityNum; i++) {
        int tmp;
        cin >> tmp;
        city.push_back(tmp);
    }

    ll answer = 0;
    ll minPrice = 987654321;

    // i번째 도시에서 i+1번째 도시로 갈때까지의 계산
    for (ll i = 0; i < dist.size(); i++) {
        minPrice = min(minPrice, city[i]);
        answer += dist[i] * minPrice;
    }

    cout << answer << ENDL;
    return 0;
}
