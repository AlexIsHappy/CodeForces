#include <bits/stdc++.h>
using namespace std;

using ll = long long;

int main() {
	int n;
	ll k;
	cin >> n >> k;
	vector <ll> a(n);
	for (int i = 0; i < n; ++i) {
		cin >> a[i];
	}
	map <ll, ll> left, right;
	for (int i = 1; i < n; ++i) {
		right[a[i]]++;
	}
	ll ans = 0;
	for (int i = 0; i < n; ++i) {
		if (a[i] % k == 0) {
			ans += left[a[i] / k] * right[a[i] * k];
		}
		if (i + 1 < n)
			right[a[i + 1]]--;
		left[a[i]]++;
	}
	cout << ans << endl;
	return 0;
}