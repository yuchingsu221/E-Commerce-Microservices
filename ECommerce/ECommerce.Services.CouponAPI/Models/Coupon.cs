using System.ComponentModel.DataAnnotations;

namespace ECommerce.Services.CouponAPI.Models
{
    public class Coupon
    {
        /// <summary>
        /// 優惠券 ID
        /// </summary>
        [Key]
        public int CouponId { get; set; }
        /// <summary>
        /// 優惠券代碼
        /// </summary>
        [Required]
        public string CouponCode { get; set; }
        /// <summary>
        /// 折扣金額
        /// </summary>
        [Required]
        public double DiscountAmount { get; set; }
        /// <summary>
        /// 最低價格
        /// </summary>
        public int MinAmount { get; set; }
    }
}
