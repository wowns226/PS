#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

using namespace std;

int main() {
    FASTIO;

    string s;
    float answer = 0;
    cin >> s;

    switch (s[0]) {
        case 'A':
            answer += 4;
            break;
        case 'B':
            answer += 3;
            break;
        case 'C':
            answer += 2;
            break;
        case 'D':
            answer += 1;
            break;
        case 'F':
            answer += 0;
            break;
    }

    switch (s[1]) {
        case '+':
            answer += 0.3;
            break;
        case '-':
            answer -= 0.3;
            break;
    }

    cout << fixed;
    cout.precision(1);
    cout << answer;
}