#include <cstdio>
#include <cstdlib>
#include <cstring>
#include <cmath>
#include <iostream>
#include <sstream>
#include <vector>
#include <list>
#include <deque>
#include <queue>
#include <stack>
#include <set>
#include <map>
#include <utility>
#include <algorithm>
#include <limits>
#include <iomanip>
#include <bitset>

#define INF 1000000000
#define Inf 1000000000000000000
#define mp make_pair
#define pb push_back
#define EPS 1e-9
#define forin for(int i = 0;i < n;i++)

using namespace std;

typedef long long ll;
typedef pair<int, int> ii;
typedef vector<ii> vii;
typedef vector<int> vi;
typedef vector<vi> vvi;
typedef vector<vii> vvii;


int a[1000010];  // 10 v 5 stepeni
long long cnt[1000010];


int main() {

	int n;
	cin >> n;
	long long s = 0;
	for (int i = 0; i < n; ++i)
	{
		cin >> a[i];
		s += a[i];
	}
	if (s % 3 != 0)
		cout << "0\n";
	else {
		s /= 3;

		long long ss = 0;

		for (int i = n - 1; i >= 0; --i)
		{
			ss += a[i];
			if (ss == s)
				cnt[i] = 1;
		}


		for (int i = n - 2; i >= 0; --i)
			cnt[i] += cnt[i + 1];

		long long ans = 0;
		ss = 0;

		for (int i = 0; i + 2 < n; ++i) {
			ss += a[i];
			if (ss == s)
				ans += cnt[i + 2];
		}
		cout << ans << "\n";
	}


	//------
	int end;
	cin >> end;
	return 0;
}