/*
  Given a string s, find the length of the longest
  substring
  without repeating characters.

  Example 1:

  Input: s = "abcabcbb"
  Output: 3
  Explanation: The answer is "abc", with the length of 3.

  Example 2:

  Input: s = "bbbbb"
  Output: 1
  Explanation: The answer is "b", with the length of 1.

  Example 3:

  Input: s = "pwwkew"
  Output: 3
  Explanation: The answer is "wke", with the length of 3.
  Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
*/

function generateUniqueSubstring(string, substring, index) {
  if (string.length === index) return { substring, nextSubstringIndex: -1 };

  if (!substring)
    return generateUniqueSubstring(
      string,
      `${substring}${string[index]}`,
      index + 1
    );
  else {
    if (substring.includes(string[index])) {
      return {
        substring,
        nextSubstringIndex: index,
      };
    } else {
      return generateUniqueSubstring(
        string,
        `${substring}${string[index]}`,
        index + 1
      );
    }
  }
}

function logestSubstringWithoutRepeatingCharacters(s) {
  console.log("----");
  console.log(`Input: s = "${s}"`);

  let index = 0;
  let substrings = [];

  do {
    const results = generateUniqueSubstring(s, "", index);

    substrings.push(results.substring);

    index = results.nextSubstringIndex;
  } while (index != -1);

  substrings = substrings.sort((a, b) => b.length - a.length);

  console.log(`Output: ${substrings[0].length}`);
  console.log(`Biggest substring: ${substrings[0]}`);
  console.log("----");
}

logestSubstringWithoutRepeatingCharacters("abcabcbb"); // Output: 3
// Explanation: The answer is "abc", with the length of 3.
logestSubstringWithoutRepeatingCharacters("bbbbb"); // Output: 1
// Explanation: The answer is "b", with the length of 1.
logestSubstringWithoutRepeatingCharacters("pwwkew"); // Output: 3
// Explanation: The answer is "wke", with the length of 3.
// Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
