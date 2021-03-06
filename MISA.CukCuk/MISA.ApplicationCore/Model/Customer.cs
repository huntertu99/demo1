﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.ApplicationCore.Model
{
    public class Customer:BaseEntity
    {
        public Customer() { }
        #region Property
        /// <summary>
        /// Khóa chính
        /// </summary>
        [PrimaryKey]
        public Guid CustomerId { get; set; }

        /// <summary>
        /// mã khách hàng
        /// </summary>
        [Requirt]
        [CheckDuplicate]
        public string CustomerCode { get; set; }

        /// <summary>
        /// họ tên
        /// </summary>
        [Requirt]
        [CheckDuplicate]
        public string FullName { get; set; }

        /// <summary>
        /// số thẻ thành viên
        /// </summary>
        [Requirt]
        [CheckDuplicate]
        public string MemberCardCode { get; set; }

        /// <summary>
        /// nhóm khách hàng
        /// </summary>
        [Requirt]
        [CheckDuplicate]
        public Guid CustomerGroupId { get; set; }

        /// <summary>
        /// ngày sinh
        /// </summary>
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// giới tính
        /// </summary>
        public int? Gender { get; set; }

        /// <summary>
        /// địa chỉ email
        /// </summary>
        [Requirt]
        [CheckDuplicate]
        public string Email { get; set; }

        /// <summary>
        /// số điện thoại
        /// </summary>
        [Requirt]
        [CheckDuplicate]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// tên công ty
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// mã số thuế công ty
        /// </summary>
        public string CompanyTaxCode { get; set; }

        /// <summary>
        /// địa chỉ
        /// </summary>
        public string Address { get; set; }

        #endregion

    }
}
