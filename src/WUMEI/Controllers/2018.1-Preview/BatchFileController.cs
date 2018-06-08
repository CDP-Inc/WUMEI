using Microsoft.AspNetCore.Mvc;
using WUMEI.Models;

namespace WUMEI.Controllers
{
    /// <summary>
    /// The Batch file functional area comprises functions used for the transfer of bulk data between the WIC MIS
    /// and WIC EBT system and to synchronize data stored in separate locations. This may be a two-way data flow,
    /// with some transfers being initiated by the WIC MIS and others by the WIC EBT system.
    /// </summary>
    [ApiVersion("2018.1-Preview")]
    [Route("wumei/{version:apiVersion}/[controller]/[action]")]
    public class BatchFileController : Controller
    {
        /// <summary>
        /// Report Daily Outstanding Liability is an optional function uses a batch based system interface for the 
        /// WIC EBT System to provide the WIC State Agency's outstanding liability of benefits to be used to reconcile
        /// with the WIC MIS. The report is produced daily and covers the 24 hour cutoff period
        /// agreed to between the MIS and EBT systems.
        /// </summary>
        /// <param name="liability"></param>
        /// <returns></returns>
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(BatchConfirmationFile), 200)]
        public IActionResult ReportDailyOutstandingLiability(
            [FromBody]ReportDailyOutstandingLiability liability
        )
        {
            return Ok(new BatchConfirmationFile());
        }

        /// <summary>
        /// Report Card Updates is an optional function uses a batch system interface to allow the WIC MIS to update 
        /// its records to reflect any changes made via the WIC EBT system or at the POS. This function is required if
        /// a WIC State Agency chooses to maintain card status on the WIC MIS and also allows changes to be made to
        /// card status via the WIC EBT system.
        /// </summary>
        /// <remarks>
        /// The batch name is WIC EBT Card Updates file.
        /// </remarks>
        /// <param name="card"></param>
        /// <returns></returns>
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(BatchConfirmationFile), 200)]
        public IActionResult ReportCardUpdates(
            [FromBody]ReportCardUpdates card
        )
        {
            return Ok(new BatchConfirmationFile());
        }

        /// <summary>
        /// The Add or Update WIC Vendor function is a required function that uses a message or batch based 
        /// system interface to establish or modify WIC Vendor information in the WIC EBT System.
        /// </summary>
        /// <remarks>
        /// The batch name is WIC Vendor File.
        /// </remarks>
        /// <param name="vendor"></param>
        /// <returns></returns>
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(BatchConfirmationFile), 200)]
        public IActionResult AddUpdateWicVendorBatch(
            [FromBody]AddUpdateWicVendorBatch vendor
        )
        {
            return Ok(new BatchConfirmationFile());
        }

        /// <summary>
        /// The Add or Update WIC Vendor Hierarchy Information function is an optional function that uses a 
        /// message or batch system interface to create and update the WIC EBT system’s WIC Vendor corporate
        /// levels of information.
        /// </summary>
        /// <remarks>
        /// The batch name is WIC Vendor Corporate Information File.
        /// </remarks>
        /// <param name="hierarchy"></param>
        /// <returns></returns>
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(BatchConfirmationFile), 200)]
        public IActionResult AddUpdateWicVendorHierarchyInformationBatch(
            [FromBody]AddUpdateWicVendorHierarchyInformationBatch hierarchy
        )
        {
            return Ok(new BatchConfirmationFile());
        }

        /// <summary>
        /// The Update WIC Vendor Status function is an optional function that uses a message or batch system
        /// interface to set the new status of the WIC Vendor.
        /// </summary>
        /// <remarks>
        /// The batch name is WIC Vendor Status File.
        /// </remarks>
        /// <param name="vendor"></param>
        /// <returns></returns>
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(BatchConfirmationFile), 200)]
        public IActionResult UpdateWicVendorStatusBatch(
            [FromBody]UpdateWicVendorStatusBatch vendor
        )
        {
            return Ok(new BatchConfirmationFile());
        }

        /// <summary>
        /// The Update WIC Vendor Banking Information function is an optional function that uses a message or 
        /// batch based system interface to add, change or delete banking information for a WIC Vendor in the WIC 
        /// EBT system.
        /// </summary>
        /// <remarks>
        /// The batch name is WIC Vendor Banking Information file.
        /// </remarks>
        /// <param name="vendor"></param>
        /// <returns></returns>
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(BatchConfirmationFile), 200)]
        public IActionResult UpdateWicVendorBankingInformationBatch(
            [FromBody]UpdateWicVendorBankingInformationBatch vendor
        )
        {
            return Ok(new BatchConfirmationFile());
        }

        /// <summary>
        /// The Add or Update Category/Subcategory Information function is a required function that uses a
        /// batch system interface to provide updates to the Category and Subcategory information from the system
        /// maintaining the information derived form the NUPC database used to create the UPC/PLU data file.
        /// </summary>
        /// <remarks>
        /// The batch name is WIC Category Subcategory file.
        /// </remarks>
        /// <param name="category"></param>
        /// <returns></returns>
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(BatchConfirmationFile), 200)]
        public IActionResult AddUpdateCategorySubcategoryInformation(
            [FromBody]AddUpdateCategorySubcategoryInformation category
        )
        {
            return Ok(new BatchConfirmationFile());
        }

        /// <summary>
        /// The Add or Update UPC/PLU Information function is a required function that uses a batch system interface
        /// to provide updates to the UPC/PLU information from the system maintaining the WIC State Agency APL file.
        /// </summary>
        /// <remarks>
        /// The batch name is the WIC UPC/PLU file. This file differs from the Authorized Product List (APL) File
        /// provided to WIC Vendors as it contains WIC Vendor peer group data.
        /// </remarks>
        /// <param name="upcPlu"></param>
        /// <returns></returns>
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(BatchConfirmationFile), 200)]
        public IActionResult AddUpdateUpcPluInformation(
            [FromBody]AddUpdateUpcPluInformation upcPlu
        )
        {
            return Ok(new BatchConfirmationFile());
        }

        /// <summary>
        /// The Report WIC Benefit Redemptions function is a required function that uses a batch system interface
        /// to provide a detailed record of all benefit redemption activity on a daily basis from the WIC EBT system.
        /// A WIC MIS may receive this batch for NTE calculation and maintenance, reporting, reconciliation and
        /// program management.
        /// </summary>
        /// <remarks>
        /// The batch name is WIC Benefit Redemption File.
        /// </remarks>
        /// <param name="benefits"></param>
        /// <returns></returns>
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(BatchConfirmationFile), 200)]
        public IActionResult ReportWicBenefitRedemptions(
            [FromBody]ReportWicBenefitRedemptions benefits
        )
        {
            return Ok(new BatchConfirmationFile());
        }

        /// <summary>
        /// The Report WIC Benefits Purged function is a required function that uses a batch system interface
        /// to provide a detailed record of benefits purged from the WIC EBT system. All benefits purged by
        /// the WIC EBT system are included in this function.
        /// </summary>
        /// <remarks>
        /// The batch name is WIC Benefits Purged File.
        /// </remarks>
        /// <param name="benefits"></param>
        /// <returns></returns>
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(BatchConfirmationFile), 200)]
        public IActionResult ReportWicBenefitsPurged(
            [FromBody]ReportWicBenefitsPurged benefits
        )
        {
            return Ok(new BatchConfirmationFile());
        }

        /// <summary>
        /// The Report WIC Benefit Changes function is a required function that uses a batch system interface
        /// to create a batch that contains information for each WIC MIS initiated Add or Update Benefits transaction
        /// (issuances, updates and voids) that ws accepted and approved by the WIC EBT system during the prior
        /// 24 hour period.
        /// </summary>
        /// <remarks>
        /// The batch name is WIC Daily Interface Reconciliation file.
        /// </remarks>
        /// <param name="benefits"></param>
        /// <returns></returns>
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(BatchConfirmationFile), 200)]
        public IActionResult ReportWicBenefitChanges(
            [FromBody]ReportWicBenefitChanges benefits
        )
        {
            return Ok(new BatchConfirmationFile());
        }

        /// <summary>
        /// The Report WIC Benefit Month data function is an optional function that uses a batch system interface to
        /// provide the data necessary for a final point of reconciliation of all benefit activity for a given
        /// Benefit month against the WIC financial accounting for that month as documented in the WIC Financial
        /// Management and Participation (FNS-798 report and FNS policy).
        /// </summary>
        /// <remarks>
        /// The batch name is WIC Benefit Month Data File.
        /// </remarks>
        /// <param name="benefit"></param>
        /// <returns></returns>
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(BatchConfirmationFile), 200)]
        public IActionResult ReportWicBenefitMonthData(
            [FromBody]ReportWicBenefitMonthData benefit
        )
        {
            return Ok(new BatchConfirmationFile());
        }

        /// <summary>
        /// The Request ACH Payment function is an optional function that uses a message or batch based system 
        /// interface to allow the WIC State Agency or EBT Card Issuer Processor to make a payment or adjustment
        /// to a WIC Vendor, a WIC Vendor corporate entity or their agent that is outside the normal course of
        /// benefit redemption and settlement.
        /// </summary>
        /// <remarks>
        /// The batch name is WIC ACH Payment File.
        /// </remarks>
        /// <param name="ach"></param>
        /// <returns></returns>
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(BatchConfirmationFile), 200)]
        public IActionResult RequestAchPaymentBatch(
            [FromBody]RequestAchPaymentBatch ach
        )
        {
            return Ok(new BatchConfirmationFile());
        }

        /// <summary>
        /// The Report ACH Payments function is an optional function that uses a batch based system interface to 
        /// have the WIC EBT System report all WIC ACH payments requested by the WIC MIS and any initiated by the
        /// WIC EBT System.
        /// </summary>
        /// <param name="ach"></param>
        /// <returns></returns>
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(BatchConfirmationFile), 200)]
        public IActionResult ReportAchPayments(
            [FromBody]ReportAchPayments ach
        )
        {
            return Ok(new BatchConfirmationFile());
        }
        
        /// <summary>
        /// The Report Recoupment Requests function uses a batch system interface to allow the sender to notify the
        /// WIC EBT System of the amounts to be recouped from each vendor.
        /// </summary>
        /// <remarks>
        /// The file name is the WIC Recoupment Request File.
        /// </remarks>
        /// <param name="recoupment"></param>
        /// <returns></returns>
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(BatchConfirmationFile), 200)]
        public IActionResult ReportRecoupmentRequests(
            [FromBody]ReportRecoupmentRequests recoupment
        )
        {
            return Ok(new BatchConfirmationFile());
        }

        /// <summary>
        /// The Report Recoupment Status function uses a batch system interface to allow the WIC EBT System
        /// to report the daily status of recoupment activity by vendor.
        /// </summary>
        /// <remarks>
        /// The file name is the WIC Recoupment Status File.
        /// </remarks>
        /// <param name="recoupment"></param>
        /// <returns></returns>
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(BatchConfirmationFile), 200)]
        public IActionResult ReportRecoupmentStatus(
            [FromBody]ReportRecoupmentStatus recoupment
        )
        {
            return Ok(new BatchConfirmationFile());
        }
    }
}
