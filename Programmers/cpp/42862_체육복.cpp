// 19 20 25 테스트 실패
// 예외 : 7, { 2,4 }, { 1,3 } 정답 : 7
#include<bits/stdc++.h>

#define EL "\n";

using namespace std;

int solution(int n, vector<int> lost, vector<int> reserve) {
	// 전체 학생
	vector<int> v(n, 1);
	int answer = n;
	// 체육복을 잃어버린 학생 인덱스값 감소
	for (int i = 0; i < lost.size(); i++) {
		v[lost[i]-1]--;
	}

	// 여분의 체육복을 가진 학생 인덱스값 증가
	for (int i = 0; i < reserve.size(); i++) {
		v[reserve[i]-1]++;
	}

	for (int i = 0; i < v.size(); i++) {
		// i번째 학생이 체육복이 없다면
		if (v[i] == 0) {
			// 앞번호 학생이 여분의 체육복이 있다면
			if (i - 1 >= 0 && v[i - 1] == 2) {
				// 빌려주기
				v[i + 1]--;
				v[i]++;
			}
			// 뒷번호 학생이 여분의 체육복이 있다면
			else if (i + 1 < n && v[i + 1] == 2) {
				// 빌려주기
				v[i - 1]--;
				v[i]++;
			}
			else {
				answer--;
			}
		}
	}

	return answer;
}

void print(int n, vector<int> lost, vector<int> reserve, int answer) {
	int t = solution(n, lost, reserve);
	if (t == answer) {
		cout << "정답" << endl;
	}
	else {
		cout << "틀림" << endl;
	}
}

int main() {
	print(5, { 2, 4 }, { 1, 3, 5 }, 5);
	print(5, { 2, 4 }, { 3 }, 4);
	print(3, { 3 }, { 1 }, 2);
	print(7, { 2, 3, 4 }, { 1, 2, 3, 6 }, 6);
	print(5, { 5 }, { 4 }, 5);
	print(7, { 2,4 }, { 1,3 }, 7);

	return 0;
}