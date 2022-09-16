#include <bits/stdc++.h>

#define FASTIO                             \
    std::ios_base::sync_with_stdio(false); \
    std::cin.tie(0);                       \
    std::cout.tie(0)
#define ENDL '\n'

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/1780
 ***************************************************************************************/

// * 함수 정의
// void func(int x,int y,int n)

// * Base Condition
// 끝까지 다 돌았을때 끝냄
// if(board[x][y] == board[_x][_y])

// * 재귀 식
//

using namespace std;

const int MAX = 2200;

int n, a = 0, b = 0, c = 0;
int board[MAX][MAX];

void func(int x, int y, int n) {
    bool isSame = true;
    for (int i = x; i < x + n; i++) {
        for (int j = y; j < y + n; j++) {
            if (board[x][y] != board[i][j]) {
                isSame = false;
                break;
            }
        }

        if (!isSame) {
            break;
        }
    }

    if (isSame) {
        if (board[x][y] == -1) {
            a++;
        } else if (board[x][y] == 0) {
            b++;
        } else {
            c++;
        }
    } else {
        func(x, y, n / 3);                                  // 1
        func(x + n / 3, y, n / 3);                          // 2
        func(x + n / 3 + n / 3, y, n / 3);                  // 3
        func(x, y + n / 3, n / 3);                          // 4
        func(x, y + n / 3 + n / 3, n / 3);                  // 7
        func(x + n / 3, y + n / 3, n / 3);                  // 5
        func(x + n / 3 + n / 3, y + n / 3 + n / 3, n / 3);  // 9
        func(x + n / 3, y + n / 3 + n / 3, n / 3);          // 8
        func(x + n / 3 + n / 3, y + n / 3, n / 3);          // 6
    }
}

int main() {
    FASTIO;
    cin >> n;
    for (int x = 0; x < n; x++) {
        for (int y = 0; y < n; y++) {
            cin >> board[x][y];
        }
    }

    func(0, 0, n);

    cout << a << ENDL;
    cout << b << ENDL;
    cout << c << ENDL;

    return 0;
}
