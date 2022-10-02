#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/1759
 ***************************************************************************************/

using namespace std;

int l, c;
int arr[17];
char board[17];
bool isVisited[17];

bool isVowel(char c) {
    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u') {
        return true;
    }

    return false;
}

void func(int k, int idx) {
    if (k == l) {
        bool isDone = false;
        int cnt1 = 0;
        int cnt2 = 0;
        for (int i = 0; i < l; i++) {
            if (isVowel(board[arr[i]])) {
                cnt1++;
            } else {
                cnt2++;
            }
        }

        if (cnt1 >= 1 && cnt2 >= 2) isDone = true;

        if (isDone) {
            for (int i = 0; i < l; i++) {
                cout << board[arr[i]];
            }
            cout << ENDL;
        }
    }

    for (int i = idx; i < c; i++) {
        arr[k] = i;
        func(k + 1, i + 1);
    }
}

int main() {
    FASTIO;
    cin >> l >> c;
    for (int i = 0; i < c; i++) {
        cin >> board[i];
    }

    sort(board, board + c);

    func(0, 0);

    return 0;
}
