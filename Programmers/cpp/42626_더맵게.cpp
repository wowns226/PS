// 테스트케이스 2,3,25번 실패
// 해결 => 첫 벡터가 정렬 상태가 아닌경우
// 효율성 테스트 : all 시간초과
// 해결 => 우선순위 큐
#include<bits/stdc++.h>

#define EL "\n";

using namespace std;

int solution(vector<int> scoville, int K) {
	int answer = 0;
	priority_queue<int, vector<int>, greater<int>> pq;
	for (const auto& v : scoville)
		pq.push(v);

	auto first_value = pq.top();
	while ((pq.size() > 1) && (first_value < K)) {
		pq.pop();
		int second_value = pq.top();
		pq.pop();

		int new_value = first_value + second_value * 2;

		pq.push(new_value);

		++answer;

		first_value = pq.top();
	}

	if (first_value < K) answer = -1;

	return answer;
}

void test_case(vector<int> scoville, int K, int answer) {
	int t = solution(scoville, K);
	if (t == answer) cout << "정답" << endl;
	else cout << "틀림" << endl;
}

int main() {
	test_case({ 1,2,3,9,10,12 }, 7, 2);
	test_case({ 9,10,1,2,3,12 }, 7, 2);
	test_case({ 7 }, 7, 0);
	test_case({ 0,1 }, 2, 1);

	return 0;
}