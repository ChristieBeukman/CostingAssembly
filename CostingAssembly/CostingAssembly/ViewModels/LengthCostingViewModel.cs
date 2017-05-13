using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CostingAssembly.Models;

namespace CostingAssembly.ViewModels
{
    public class LengthCostingViewModel : BaseViewModel
    {
        dbNewEntities ctx = new dbNewEntities(); // Data model Entities datacontext

        #region Properties

        #region Private Properties

        private List<JoinedLengthModel> _JoinedLengthModel;
        private JoinedLengthModel _SelectedLenghMaterial;
        #endregion

        #region Public Properties

        public List<JoinedLengthModel> JoinedLengthModel
        {
            get
            {
                return _JoinedLengthModel;
            }

            set
            {
                _JoinedLengthModel = value;
                NotifyPropertyChanged();
            }
        }

        public JoinedLengthModel SelectedLenghMaterial
        {
            get
            {
                return _SelectedLenghMaterial;
            }

            set
            {
                _SelectedLenghMaterial = value;
            }
        }

        #endregion

        #endregion

        #region Constructor

        public LengthCostingViewModel()
        {

        }



        #endregion

        #region Select

        /// <summary>
        /// Select all lenght data with a left join to view mateerial name and descriptopm
        /// </summary>
        private void GetLengthMaterials()
        {
            var Query = (from l in ctx.tblLengthCosts
                         join m in ctx.tblMaterials
                         on l.MaterialID equals m.MaterialID
                         select new JoinedLengthModel
                         {
                             MaterialID = l.MaterialID,
                             Name = m.Name,
                             Description = m.Description,
                             NoPieces = l.NoPieces,
                             LengthPerPiece = l.LengthPerPiece,
                             TotalCostPieces = l.TotalCostPieces,
                             TotalLength = l.TotalLength,
                             PricePerMeter = l.PricePerMeter
                         }).ToList();
            this.JoinedLengthModel = Query;
        }

#endregion


    }
}
