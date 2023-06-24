#include<bits/stdc++.h>

#define EL "\n";

using namespace std;

string solution(vector<string> participant, vector<string> completion) {
	string answer = "";
	map<string, int> m;
	
	for (int i = 0; i < participant.size(); i++) {
		if (m.find(participant[i]) != m.end()) {
			m[participant[i]]++;
		}
		else {
			m.insert({ participant[i], 1 });
		}
	}

	for (int i = 0; i < completion.size(); i++) {
		if (m.find(completion[i]) != m.end()) {
			m[completion[i]]--;
		}
	}

	for (auto iter = m.begin(); iter != m.end(); iter++) {
		if (iter->second == 1)
			return iter->first;
	}
}

void testCase(vector<string> participant, vector<string> completion, string answer) {
	string t = solution(participant, completion);
	if (t == answer) cout << "정답" << endl;
	else cout << "틀림" << endl;
}

int main() {
	testCase({ "leo", "kiki", "eden" }, { "eden", "kiki" },  "leo");
	testCase({ "marina", "josipa", "nikola", "vinko", "filipa" }, { "josipa", "filipa", "marina", "nikola" }, "vinko");
	testCase({ "mislav", "stanko", "mislav", "ana" }, { "stanko", "ana", "mislav" }, "mislav");
	return 0;
}