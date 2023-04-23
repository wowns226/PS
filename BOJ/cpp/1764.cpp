#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'
#define LL long long

using namespace std;

int main() {
    FASTIO;

    map<string, int> ma;
    vector<string> v;
    int n, m;
    cin >> n >> m;
    for (int i = 0; i < n + m; i++) {
        string s;
        cin >> s;
        ma[s]++;
        if (ma[s] > 1) v.push_back(s);
    }

    sort(v.begin(), v.end());

    cout << v.size() << ENDL;
    for (int i = 0; i < v.size(); i++) {
        cout << v[i] << ENDL;
    }

    return 0;
}