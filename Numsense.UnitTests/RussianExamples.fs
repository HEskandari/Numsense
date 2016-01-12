﻿module Ploeh.Numsense.RussianExamples

open Xunit
open Swensen.Unquote

[<Theory>]
[<InlineData(                                             "ноль",          0)>]
[<InlineData(                                            " ноль",          0)>]
[<InlineData(                                            "ноль ",          0)>]
[<InlineData(                                         "  ноль  ",          0)>]
[<InlineData(                                             "Ноль",          0)>]
[<InlineData(                                             "НОЛЬ",          0)>]
[<InlineData(                                          " нОЛь\t",          0)>]
[<InlineData(                                             "один",          1)>]
[<InlineData(                                             "ОДИН",          1)>]
[<InlineData(                                              "два",          2)>]
[<InlineData(                                             " два",          2)>]
[<InlineData(                                              "три",          3)>]
[<InlineData(                                            "три  ",          3)>]
[<InlineData(                                           "четыре",          4)>]
[<InlineData(                                        "  четыре ",          4)>]
[<InlineData(                                             "пять",          5)>]
[<InlineData(                                             "ПятЬ",          5)>]
[<InlineData(                                            "шесть",          6)>]
[<InlineData(                                        "  ШЕСТЬ  ",          6)>]
[<InlineData(                                             "семь",          7)>]
[<InlineData(                                         "    сеМь",          7)>]
[<InlineData(                                           "восемь",          8)>]
[<InlineData(                                           "вОСЕМЬ",          8)>]
[<InlineData(                                           "девять",          9)>]
[<InlineData(                                         "ДеВяТь  ",          9)>]
[<InlineData(                                           "десять",         10)>]
[<InlineData(                                      "одиннадцать",         11)>]
[<InlineData(                                       "двенадцать",         12)>]
[<InlineData(                                       "тринадцать",         13)>]
[<InlineData(                                     "четырнадцать",         14)>]
[<InlineData(                                       "пятнадцать",         15)>]
[<InlineData(                                      "шестнадцать",         16)>]
[<InlineData(                                       "семнадцать",         17)>]
[<InlineData(                                     "восемнадцать",         18)>]
[<InlineData(                                     "девятнадцать",         19)>]
[<InlineData(                                         "двадцать",         20)>]
[<InlineData(                                    "двадцать одно",         21)>]
[<InlineData(                                         "тридцать",         30)>]
[<InlineData(                                  "тридцать четыре",         34)>]
[<InlineData(                                  "тридцать восемь",         38)>]
[<InlineData(                                            "сорок",         40)>]
[<InlineData(                                       "сорок один",         41)>]
[<InlineData(                                     "сорок четыре",         44)>]
[<InlineData(                                        "пятьдесят",         50)>]
[<InlineData(                                   "пятьдесят семь",         57)>]
[<InlineData(                                       "шестьдесят",         60)>]
[<InlineData(                                  "шестьдесят пять",         65)>]
[<InlineData(                                        "семьдесят",         70)>]
[<InlineData(                                   "семьдесят семь",         77)>]
[<InlineData(                                 "семьдесят девять",         79)>]
[<InlineData(                                      "восемьдесят",         80)>]
[<InlineData(                                "восемьдесят шесть",         86)>]
[<InlineData(                                        "девяносто",         90)>]
[<InlineData(                                    "девяносто три",         93)>]
[<InlineData(                                              "сто",        100)>]
[<InlineData(                                         "сто один",        101)>]
[<InlineData(                                           "двести",        200)>]
[<InlineData(                             "двести тридцать семь",        237)>]
[<InlineData(                            "триста семьдесят пять",        375)>]
[<InlineData(                              "четыреста девяносто",        490)>]
[<InlineData(                           "пятьсот шестьдесят три",        563)>]
[<InlineData(                            "шестьсот восемнадцать",        618)>]
[<InlineData(                           "семьсот семьдесят семь",        777)>]
[<InlineData(                                   "восемьсот пять",        805)>]
[<InlineData(                       "девятьсот пятьдесят девять",        959)>]
[<InlineData(                                           "тысяча",       1000)>]
[<InlineData(                                      "одна тысяча",       1000)>]
[<InlineData(                                      "тысяча один",       1001)>]
[<InlineData(                                  "одна тысяча два",       1002)>]
[<InlineData(                    "одна тысяча шестьдесят четыре",       1064)>]
[<InlineData(                                       "две тысячи",       2000)>]
[<InlineData(                                       "три тысячи",       3000)>]
[<InlineData(                                    "четыре тысячи",       4000)>]
[<InlineData(                                      "пять тысячи",       5000)>]
[<InlineData(              "восемь тысячь семьсот двадцать один",       8721)>]
[<InlineData(                   "девять тысячь сто двадцать три",       9123)>]
[<InlineData(                                    "десять тысячь",      10000)>]
[<InlineData(                           "десять тысячь сто один",      10101)>]
[<InlineData(             "одиннадцать тысячь двести тринадцать",      11213)>]
[<InlineData(                                       "сто тысячь",     100000)>]
[<InlineData(                                  "сто тысячь один",     100001)>]
[<InlineData(     "сто двадцать одна тысяча триста четырнадцать",     121314)>]
[<InlineData(                                          "миллион",    1000000)>]
[<InlineData(                                     "один миллион",    1000000)>]
[<InlineData(                              "два миллиона десять",    2000010)>]
[<InlineData(                                     "три миллиона",    3000000)>]
[<InlineData(                                  "четыре миллиона",    4000000)>]
[<InlineData(                                   "пять миллионов",    5000000)>]
[<InlineData(                  "шесть миллионов тридцать тысячь",    6030000)>]
[<InlineData(
      "девять миллионов двести одна тысяча шестьсот восемьдесят",    9201680)>]
[<InlineData(                                 "десять миллионов",   10000000)>]
[<InlineData(                          "десять миллионов девять",   10000009)>]
[<InlineData(                            "двадцать один миллион",   21000000)>]
[<InlineData(
    "сорок семь миллионов шестьсот шестьдесят одна тысяча шестьдесят",
    47661060)>]
[<InlineData(                                    "сто миллионов",  100000000)>]
[<InlineData(                            "двести пять миллионов",  205000000)>]
[<InlineData(                            "триста семь миллионов",  307000000)>]
[<InlineData(
    "четыреста шестьдесят один миллион шестьдесят тысячь шестьсот",
    461060600)>]
[<InlineData(                                    "один миллиард", 1000000000)>]
[<InlineData(                                    "два миллиарда", 2000000000)>]
[<InlineData(
    "два миллиарда сорок девять миллионов шестьсот пятьдесят тысячь",
    2049650000)>]
[<InlineData(
    "два миллиарда сто сорок семь миллионов четыреста восемьдесят три тысячи шестьсот сорок семь",
    System.Int32.MaxValue)>]
let ``tryOfRussian returns correct result`` (russian, expected) =
    let actual = Numeral.tryParseRussian russian
    Some expected =! actual

[<Theory>]
[<InlineData(         0, "ноль")>]
[<InlineData(         1, "один")>]
[<InlineData(         2, "два")>]
[<InlineData(         3, "три")>]
[<InlineData(         4, "четыре")>]
[<InlineData(         5, "пять")>]
[<InlineData(         6, "шесть")>]
[<InlineData(         7, "семь")>]
[<InlineData(         8, "восемь")>]
[<InlineData(         9, "девять")>]
[<InlineData(        10, "десять")>]
[<InlineData(        11, "одиннадцать")>]
[<InlineData(        12, "двенадцать")>]
[<InlineData(        13, "тринадцать")>]
[<InlineData(        14, "четырнадцать")>]
[<InlineData(        15, "пятнадцать")>]
[<InlineData(        16, "шестнадцать")>]
[<InlineData(        17, "семнадцать")>]
[<InlineData(        18, "восемнадцать")>]
[<InlineData(        19, "девятнадцать")>]
[<InlineData(        20, "двадцать")>]
[<InlineData(        21, "двадцать один")>]
[<InlineData(        30, "тридцать")>]
[<InlineData(        34, "тридцать четыре")>]
[<InlineData(        40, "сорок")>]
[<InlineData(        42, "сорок два")>]
[<InlineData(        50, "пятьдесят")>]
[<InlineData(        58, "пятьдесят восемь")>]
[<InlineData(        60, "шестьдесят")>]
[<InlineData(        65, "шестьдесят пять")>]
[<InlineData(        70, "семьдесят")>]
[<InlineData(        79, "семьдесят девять")>]
[<InlineData(        80, "восемьдесят")>]
[<InlineData(        86, "восемьдесят шесть")>]
[<InlineData(        90, "девяносто")>]
[<InlineData(        93, "девяносто три")>]
[<InlineData(       100, "сто")>]
[<InlineData(       101, "сто один")>]
[<InlineData(       110, "сто десять")>]
[<InlineData(       114, "сто четырнадцать")>]
[<InlineData(       135, "сто тридцать пять")>]
[<InlineData(       200, "двести")>]
[<InlineData(       282, "двести восемьдесят два")>]
[<InlineData(       331, "триста тридцать один")>]
[<InlineData(       407, "четыреста семь")>]
[<InlineData(       520, "пятьсот двадцать")>]
[<InlineData(       666, "шестьсот шестьдесят шесть")>]
[<InlineData(       798, "семьсот девяносто восемь")>]
[<InlineData(       857, "восемьсот пятьдесят семь")>]
[<InlineData(       999, "девятьсот девяносто девять")>]
[<InlineData(      1000, "одна тысяча")>]
[<InlineData(      1001, "одна тысяча один")>]
[<InlineData(      1010, "одна тысяча десять")>]
[<InlineData(      1066, "одна тысяча шестьдесят шесть")>]
[<InlineData(      1337, "одна тысяча триста тридцать семь")>]
[<InlineData(      1984, "одна тысяча девятьсот восемьдесят четыре")>]
[<InlineData(      2015, "две тысячи пятнадцать")>]
[<InlineData(      3000, "три тысячи")>]
[<InlineData(      3297, "три тысячи двести девяносто семь")>]
[<InlineData(      4080, "четыре тысячи восемьдесят")>]
[<InlineData(      5011, "пять тысячь одиннадцать")>]
[<InlineData(      6025, "шесть тысячь двадцать пять")>]
[<InlineData(      7441, "семь тысячь четыреста сорок один")>]
[<InlineData(      8513, "восемь тысячь пятьсот тринадцать")>]
[<InlineData(      9000, "девять тысячь")>]
[<InlineData(     10000, "десять тысячь")>]
[<InlineData(     12001, "двенадцать тысячь один")>]
[<InlineData(     23456, "двадцать три тысячи четыреста пятьдесят шесть")>]
[<InlineData(     32109, "тридцать две тысячи сто девять")>]
[<InlineData(     40404, "сорок тысячь четыреста четыре")>]
[<InlineData(     56789, "пятьдесят шесть тысячь семьсот восемьдесят девять")>]
[<InlineData(     60015, "шестьдесят тысячь пятнадцать")>]
[<InlineData(     71003, "семьдесят одна тысяча три")>]
[<InlineData(     80522, "восемьдесят тысячь пятьсот двадцать два")>]
[<InlineData(     98765, "девяносто восемь тысячь семьсот шестьдесят пять")>]
[<InlineData(    100000, "сто тысячь")>]
[<InlineData(    100001, "сто тысячь один")>]
[<InlineData(    100010, "сто тысячь десять")>]
[<InlineData(    101010, "сто одна тысяча десять")>]
[<InlineData(    200000, "двести тысячь")>]
[<InlineData(    321000, "триста двадцать одна тысяча")>]
[<InlineData(    411416, "четыреста одиннадцать тысячь четыреста шестнадцать")>]
[<InlineData(    530121, "пятьсот тридцать тысячь сто двадцать один")>]
[<InlineData(    600000, "шестьсот тысячь")>]
[<InlineData(    788000, "семьсот восемьдесят восемь тысячь")>]
[<InlineData(    876540, "восемьсот семьдесят шесть тысячь пятьсот сорок")>]
[<InlineData(    908077, "девятьсот восемь тысячь семьдесят семь")>]
[<InlineData(   1000000, "один миллион")>]
[<InlineData(   2000002, "два миллиона два")>]
[<InlineData(   3040506, "три миллиона сорок тысячь пятьсот шесть")>]
[<InlineData(   4321000, "четыре миллиона триста двадцать одна тысяча")>]
[<InlineData(   5004621, "пять миллионов четыре тысячи шестьсот двадцать один")>]
[<InlineData(   6982001, "шесть миллионов девятьсот восемьдесят две тысячи один")>]
[<InlineData(   7000000, "семь миллионов")>]
[<InlineData(   8000220, "восемь миллионов двести двадцать")>]
[<InlineData(   9099000, "девять миллионов девяносто девять тысячь")>]
[<InlineData(  10000000, "десять миллионов")>]
[<InlineData(  24000000, "двадцать четыре миллиона")>]
[<InlineData(  39020011, "тридцать девять миллионов двадцать тысячь одиннадцать")>]
[<InlineData(  40606100, "сорок миллионов шестьсот шесть тысячь сто")>]
[<InlineData(  53000000, "пятьдесят три миллиона")>]
[<InlineData(  64000098, "шестьдесят четыре миллиона девяносто восемь")>]
[<InlineData(  70003190, "семьдесят миллионов три тысячи сто девяносто")>]
[<InlineData(  80000000, "восемьдесят миллионов")>]
[<InlineData(  99000099, "девяносто девять миллионов девяносто девять")>]
[<InlineData( 100000000, "сто миллионов")>]
[<InlineData( 209000000, "двести девять миллионов")>]
[<InlineData( 398000000, "триста девяносто восемь миллионов")>]
[<InlineData( 439011000, "четыреста тридцать девять миллионов одиннадцать тысячь")>]
[<InlineData( 560400000, "пятьсот шестьдесят миллионов четыреста тысячь")>]
[<InlineData( 600010900, "шестьсот миллионов десять тысячь девятьсот")>]
[<InlineData( 700000000, "семьсот миллионов")>]
[<InlineData( 800116000, "восемьсот миллионов сто шестнадцать тысячь")>]
[<InlineData( 900800007, "девятьсот миллионов восемьсот тысячь семь")>]
[<InlineData(1000000000, "один миллиард")>]
[<InlineData(2121000000, "два миллиарда сто двадцать один миллион")>]
[<InlineData(
    System.Int32.MaxValue,
    "два миллиарда сто сорок семь миллионов четыреста восемьдесят три тысячи шестьсот сорок семь")>]
let ``toRussian returns correct result`` (i, expected) =
    let actual = Numeral.toRussian i
    expected =! actual