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


int main() {

	long long a, b;
	cin >> a >> b;

	int c = 0;
	for (int i = 0; (1LL << i) / 2 <= b; ++i)
		for (int j = 0; j <= i - 2; ++j) {
			long long x = (1LL << i) - 1 - (1LL << j);
			c += a <= x && x <= b;
		}


	cout << c;

	//------
	int end;
	cin >> end;
	return 0;
}