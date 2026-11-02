using Mes.Common;
using System;
using System.Collections.Generic;

namespace Mes.Business
{
    /// <summary>一张刷卡用的用户卡（UI 文档 P37）。</summary>
    public class CardUser
    {
        public string Card;
        public string User;

        /// <summary>等级显示名，表里就写中文，和 权限密码.csv 的第一列同一套值。</summary>
        public string LevelTitle;

        /// <summary>等级名解析不出时是 Operator，同时 LevelKnown=false，界面要拒绝放行。</summary>
        public LoginLevel Level = LoginLevel.Operator;
        public bool LevelKnown;
    }

    /// <summary>
    /// 刷卡用户表（数据\刷卡用户.csv：卡号,用户名,等级）。
    ///
    /// 现场是读卡器把卡号当条码打进输入框，所以这里只按卡号查，不做"卡号+密码"双因子——
    /// 文档 P37 也只有刷卡登录/刷卡登出两颗按钮，没有密码框。
    /// </summary>
    public class CardUserCatalog
    {
        private readonly Dictionary<string, CardUser> byCard =
            new Dictionary<string, CardUser>(StringComparer.OrdinalIgnoreCase);

        public readonly List<CardUser> Items = new List<CardUser>();

        public int Count { get { return Items.Count; } }

        public void Load(string file)
        {
            byCard.Clear();
            Items.Clear();
            foreach (var line in TextFile.ReadAllLines(file, CodePages.Utf8WithBom()))
            {
                var cols = line.Split(',');
                if (cols.Length < 3) continue;
                var card = cols[0].Trim();
                if (card.Length == 0 || card == "卡号") continue;
                var user = new CardUser
                {
                    Card = card,
                    User = cols[1].Trim(),
                    LevelTitle = cols[2].Trim(),
                };
                user.LevelKnown = TryLevel(user);
                Items.Add(user);
                byCard[card] = user;
            }
        }

        public CardUser Find(string card)
        {
            CardUser user;
            return byCard.TryGetValue((card ?? string.Empty).Trim(), out user) ? user : null;
        }

        private static bool TryLevel(CardUser user)
        {
            for (var i = 0; i < AccessPolicy.LevelTitles.Length; i++)
            {
                if (!string.Equals(AccessPolicy.LevelTitles[i], user.LevelTitle, StringComparison.Ordinal)) continue;
                user.Level = (LoginLevel)i;
                return true;
            }
            return false;
        }
    }
}
