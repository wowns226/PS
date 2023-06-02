#include<bits/stdc++.h>

#define EL "\n";

using namespace std;

int solution(vector<vector<int>> sizes) {
	int mw=0, mh=0;
	for (int i = 0; i < sizes.size(); i++) {
		int w = sizes[i][0];
		int h = sizes[i][1];
		if (w < h) {
			int tmp = h;
			h = w;
			w = tmp;
		}
		mw = max(mw, w);
		mh = max(mh, h);
	}
	return mw * mh;
}

int main() {
	vector<vector<int>> sizes = { { 60, 50 }, { 30, 70 }, { 60, 30 }, { 80, 40 } };

	cout << solution(sizes);

	return 0;
}