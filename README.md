Playfair cipher

The Playfair Cipher is a manual symmetric encryption cipher invented in 1854 by Charles Wheatstone, however it’s name and popularity came from the endorsement of Lord Playfair.

The Playfair cipher encrypts pairs of letters (digraphs), instead of single letters as is the case with simpler substitution ciphers such as the Caesar Cipher. Frequency analysis is still possible on the Playfair cipher, however it would be against 600 possible pairs of letters instead of 26 different possible letters. For this reason the Playfair cipher is much more secure than older substitution ciphers, and it’s use continued up until WWII.

The playfair cipher starts with creating a key table. The key table is a 5×5 grid of letters that will act as the key for encrypting your plaintext. Each of the 25 letters must be unique and one letter of the alphabet (usually Q) is omitted from the table (as there are 25 spots and 26 letters in the alphabet).

Let’s say we wanted to use the phrase “Hello World” as our key. The first characters (going left to right) in the table will be the phrase, with duplicate letters removed. The rest of the table will be filled with the remaining letters of the alphabet, in order. Our key table would look like this:

H E L O W 
R D A B C
F G I J K
M N P S T
U V X Y Z

Now, we need a message to encrypt. In a playfair cipher the message is split into digraphs, pairs of two letters. If there is an odd number of letters, a Z is added to the last letter. Let’s say we want to encrypt the message “hide the gold”.

HI DE TH EG OL DZ

Now for the actual encryption process. The Playfair cipher uses a few simple rules relating to where the letters of each digraph are in relation to each other. The rules are:

If both letters are in the same column, take the letter below each one (going back to the top if at the bottom)
If both letters are in the same row, take the letter to the right of each one (going back to the left if at the farthest right)
If neither of the preceding two rules are true, form a rectangle with the two letters and take the letters on the horizontal opposite corner of the rectangle
Using these rules, the result of the encryption of “hide the gold” with the key of “hello world” would be “LF GD MW DN WO CV”.

This can be a little hard to understand at first, but once it’s understood it seems lightning fast and, for the most part, it is

Performing this quick encryption process for each digraph in the message eventually results in the entire plaintext being encrypted. Decrypting the Playfair cipher (assuming you have the key) is as simple as doing the same process in reverse. Assuming you have the same key you will always be able to create the same key table, and then decrypt any messages made using that key.

The Playfair cipher was used mainly to protect important, yet non-critical secrets, as it is quick to use and requires no special equipment. By the time enemy cryptanalysts could break the code the information it was protecting would often no longer be relevant.
