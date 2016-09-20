namespace generators {
    
    
    public class locations_filler : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar4 = default(System.Boolean); //IsContext = False IsNew = False
			Space StoredVariable0 = ((Space)root.GetComponent(typeof(Space))); //IsContext = True IsNew = False
			if(StoredVariable0 != null)
			{
				System.Boolean ifResult1; //IsContext = False IsNew = False
				
				System.Collections.Generic.List<Place> OperandVar3 = default(System.Collections.Generic.List<Place>); //IsContext = False IsNew = False
				System.Collections.Generic.List<Place> prop2 = StoredVariable0.Places; //IsContext = False IsNew = False
				if(prop2 != null)
				{
					OperandVar3 = prop2;
				}
				
				
				if(ifResult1 = ( ( (OperandVar3 != null ? OperandVar3.Count : 0))) == ( ( (0f))))
				{
					applicable = true;
					OperandVar4 = applicable;
				}
			}
			return (System.Boolean) (OperandVar4);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			
			
			
			{
				Space subContext5 = (Space)root.GetComponent(typeof(Space)); //IsContext = True IsNew = False
				
				if(subContext5 != null)
				{
					
					subContext5.Size = (System.Int32)( (5f));
					System.Single OperandVar7 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop6 = External.Random( (1f), (4f)); //IsContext = True IsNew = False
					OperandVar7 = prop6;
					for (int i = 0; i <  (OperandVar7); i++)
					{
						UnityEngine.GameObject loc = new UnityEngine.GameObject("loc"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject loc8 = loc; //IsContext = True IsNew = False
							Entity AddContext9 = (Entity)loc.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
							
							{
								
								if(AddContext9 != null)
								{
									GODelegate Lambda10 = (UnityEngine.GameObject entity) => 
									{
										
										
										{
											
											if(entity != null)
											{
												
												{
													SpaceMarker subContext11 = (SpaceMarker)AddContext9.GetComponent(typeof(SpaceMarker)); //IsContext = True IsNew = False
													
													if(subContext11 != null)
													{
														
														{
															Space subContext12 = subContext11.CurrentSpace; //IsContext = True IsNew = False
															
															if(subContext12 != null)
															{
																Place OperandVar14 = default(Place); //IsContext = False IsNew = False
																Place StoredVariable13 = ((Place)subContext12.GetComponent(typeof(Place))); //IsContext = True IsNew = False
																if(StoredVariable13 != null)
																{
																	OperandVar14 = StoredVariable13;
																}
																subContext12.Detach( (OperandVar14));
															}
														}
													}
												}
											}
										}
									};
									AddContext9.OnDestruction(Lambda10);
								}
							}
							Place AddContext15 = (Place)loc.AddComponent(typeof(Place)); //IsContext = True IsNew = True
							
							{
								
								if(AddContext15 != null)
								{
									System.Single OperandVar17 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop16 = External.Random( (1f), (3f)); //IsContext = True IsNew = False
									OperandVar17 = prop16;
									AddContext15.Size = (System.Int32)( (OperandVar17));
								}
							}
							Named AddContext18 = (Named)loc.AddComponent(typeof(Named)); //IsContext = True IsNew = True
							
							{
								
								if(AddContext18 != null)
								{
									
									
									
									
									
									System.String OperandVar20 = default(System.String); //IsContext = False IsNew = False
									System.String prop19 = External.RandomName(); //IsContext = False IsNew = False
									if(prop19 != null)
									{
										OperandVar20 = prop19;
									}
									AddContext18.Set( ("main_name"), ("_1"),( ( ("Location of "))) + ( ( (OperandVar20))));
								}
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(loc);
						Place OperandVar22 = default(Place); //IsContext = False IsNew = False
						Place StoredVariable21 = ((Place)loc.GetComponent(typeof(Place))); //IsContext = True IsNew = False
						if(StoredVariable21 != null)
						{
							OperandVar22 = StoredVariable21;
						}
						subContext5.Attach( (OperandVar22));
					}
				}
			}
		}
        }
    }
    
    public class named_ui : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar36 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable23 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = True IsNew = False
			if(StoredVariable23 != null)
			{
				System.Boolean ifResult24; //IsContext = False IsNew = False
				
				System.Boolean OperandVar31 = default(System.Boolean); //IsContext = False IsNew = False
				UnityEngine.GameObject prop25 = StoredVariable23.ShowedObject; //IsContext = False IsNew = False
				if(prop25 != null)
				{
					System.Boolean ifResult26; //IsContext = False IsNew = False
					System.Boolean OperandVar30 = default(System.Boolean); //IsContext = False IsNew = False
					Named OperandVar28 = default(Named); //IsContext = False IsNew = False
					Named StoredVariable27 = ((Named)prop25.GetComponent(typeof(Named))); //IsContext = False IsNew = False
					if(StoredVariable27 != null)
					{
						OperandVar28 = StoredVariable27;
					}
					System.Boolean prop29 = External.Has( (OperandVar28)); //IsContext = False IsNew = False
					OperandVar30 = prop29;
					if(ifResult26 =  (OperandVar30))
					{
						OperandVar31 = ifResult26;
					}
				}
				
				System.Boolean OperandVar35 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.named_ui_marker OperandVar33 = default(Blackboards.named_ui_marker); //IsContext = False IsNew = False
				Blackboards.named_ui_marker StoredVariable32 = ((Blackboards.named_ui_marker)StoredVariable23.GetComponent(typeof(Blackboards.named_ui_marker))); //IsContext = False IsNew = False
				if(StoredVariable32 != null)
				{
					OperandVar33 = StoredVariable32;
				}
				System.Boolean prop34 = External.Has( (OperandVar33)); //IsContext = False IsNew = False
				OperandVar35 = prop34;
				if(ifResult24 = ( ( (OperandVar31))) && ( (!(OperandVar35))))
				{
					applicable = true;
					OperandVar36 = applicable;
				}
			}
			return (System.Boolean) (OperandVar36);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			
			
			root.AddComponent<Blackboards.named_ui_marker>();
			root.AddComponent<TextField>();
			
			{
				TextField subContext37 = (TextField)root.GetComponent(typeof(TextField)); //IsContext = True IsNew = False
				
				if(subContext37 != null)
				{
					System.String OperandVar42 = default(System.String); //IsContext = False IsNew = False
					UiObject StoredVariable38 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = True IsNew = False
					if(StoredVariable38 != null)
					{
						UnityEngine.GameObject prop39 = StoredVariable38.ShowedObject; //IsContext = True IsNew = False
						if(prop39 != null)
						{
							Named StoredVariable40 = ((Named)prop39.GetComponent(typeof(Named))); //IsContext = True IsNew = False
							if(StoredVariable40 != null)
							{
								
								System.String prop41 = StoredVariable40.Get( ("main_name")); //IsContext = True IsNew = False
								if(prop41 != null)
								{
									OperandVar42 = prop41;
								}
							}
						}
					}
					subContext37.Set( (OperandVar42));
				}
			}
		}
        }
    }
    
    public class agents_pool_filler : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar50 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable43 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = True IsNew = False
			if(StoredVariable43 != null)
			{
				Place StoredVariable44 = ((Place)StoredVariable43.GetComponent(typeof(Place))); //IsContext = True IsNew = False
				if(StoredVariable44 != null)
				{
					System.Boolean ifResult45; //IsContext = False IsNew = False
					
					
					System.Collections.Generic.List<Agent> OperandVar47 = default(System.Collections.Generic.List<Agent>); //IsContext = False IsNew = False
					System.Collections.Generic.List<Agent> prop46 = StoredVariable44.Agents; //IsContext = False IsNew = False
					if(prop46 != null)
					{
						OperandVar47 = prop46;
					}
					
					
					
					System.Boolean OperandVar49 = default(System.Boolean); //IsContext = False IsNew = False
					
					System.Boolean prop48 = StoredVariable43.HasMarker( ("agents_pool")); //IsContext = False IsNew = False
					OperandVar49 = prop48;
					if(ifResult45 = ( (( ( (OperandVar47 != null ? OperandVar47.Count : 0))) == ( ( (0f))))) && ( ( (OperandVar49))))
					{
						applicable = true;
						OperandVar50 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar50);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			
			
			
			{
				Place subContext51 = (Place)root.GetComponent(typeof(Place)); //IsContext = True IsNew = False
				
				if(subContext51 != null)
				{
					
					subContext51.Size = (System.Int32)( (5f));
					System.Single OperandVar53 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop52 = External.Random( (1f), (4f)); //IsContext = True IsNew = False
					OperandVar53 = prop52;
					for (int i = 0; i <  (OperandVar53); i++)
					{
						UnityEngine.GameObject ag = new UnityEngine.GameObject("ag"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject ag54 = ag; //IsContext = True IsNew = False
							Entity AddContext55 = (Entity)ag.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
							
							{
								
								if(AddContext55 != null)
								{
									GODelegate Lambda56 = (UnityEngine.GameObject entity) => 
									{
										
										
										{
											
											if(entity != null)
											{
												
												{
													PlaceMarker subContext57 = (PlaceMarker)AddContext55.GetComponent(typeof(PlaceMarker)); //IsContext = True IsNew = False
													
													if(subContext57 != null)
													{
														
														{
															Place subContext58 = subContext57.CurrentPlace; //IsContext = True IsNew = False
															
															if(subContext58 != null)
															{
																Agent OperandVar60 = default(Agent); //IsContext = False IsNew = False
																Agent StoredVariable59 = ((Agent)subContext58.GetComponent(typeof(Agent))); //IsContext = True IsNew = False
																if(StoredVariable59 != null)
																{
																	OperandVar60 = StoredVariable59;
																}
																subContext58.Detach( (OperandVar60));
															}
														}
													}
												}
											}
										}
									};
									AddContext55.OnDestruction(Lambda56);
								}
							}
							Agent AddContext61 = (Agent)ag.AddComponent(typeof(Agent)); //IsContext = True IsNew = True
							Blackboards.human AddContext62 = (Blackboards.human)ag.AddComponent(typeof(Blackboards.human)); //IsContext = True IsNew = True
							
							{
								
								if(AddContext62 != null)
								{
									System.Single OperandVar64 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop63 = External.Random( (20f), (45f)); //IsContext = True IsNew = False
									OperandVar64 = prop63;
									AddContext62.Age = (System.Int32)( (OperandVar64));
								}
							}
							Named AddContext65 = (Named)ag.AddComponent(typeof(Named)); //IsContext = True IsNew = True
							
							{
								
								if(AddContext65 != null)
								{
									
									
									System.String OperandVar67 = default(System.String); //IsContext = False IsNew = False
									System.String prop66 = External.RandomName(); //IsContext = True IsNew = False
									if(prop66 != null)
									{
										OperandVar67 = prop66;
									}
									AddContext65.Set( ("main_name"), ("_1"), (OperandVar67));
								}
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(ag);
						Agent OperandVar69 = default(Agent); //IsContext = False IsNew = False
						Agent StoredVariable68 = ((Agent)ag.GetComponent(typeof(Agent))); //IsContext = True IsNew = False
						if(StoredVariable68 != null)
						{
							OperandVar69 = StoredVariable68;
						}
						subContext51.Attach( (OperandVar69));
					}
				}
			}
		}
        }
    }
    
    public class location_event : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar76 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable70 = ((Place)root.GetComponent(typeof(Place))); //IsContext = True IsNew = False
			if(StoredVariable70 != null)
			{
				System.Boolean ifResult71; //IsContext = False IsNew = False
				System.Boolean OperandVar75 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.event_marker OperandVar73 = default(Blackboards.event_marker); //IsContext = False IsNew = False
				Blackboards.event_marker StoredVariable72 = ((Blackboards.event_marker)StoredVariable70.GetComponent(typeof(Blackboards.event_marker))); //IsContext = True IsNew = False
				if(StoredVariable72 != null)
				{
					OperandVar73 = StoredVariable72;
				}
				System.Boolean prop74 = External.Has( (OperandVar73)); //IsContext = True IsNew = False
				OperandVar75 = prop74;
				if(ifResult71 = !(OperandVar75))
				{
					applicable = true;
					OperandVar76 = applicable;
				}
			}
			return (System.Boolean) (OperandVar76);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			
			
			root.AddComponent<Blackboards.event_marker>();
		}
        }
    }
    
    public class agent_personality : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar83 = default(System.Boolean); //IsContext = False IsNew = False
			Agent StoredVariable77 = ((Agent)root.GetComponent(typeof(Agent))); //IsContext = True IsNew = False
			if(StoredVariable77 != null)
			{
				System.Boolean ifResult78; //IsContext = False IsNew = False
				System.Boolean OperandVar82 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.personality OperandVar80 = default(Blackboards.personality); //IsContext = False IsNew = False
				Blackboards.personality StoredVariable79 = ((Blackboards.personality)StoredVariable77.GetComponent(typeof(Blackboards.personality))); //IsContext = True IsNew = False
				if(StoredVariable79 != null)
				{
					OperandVar80 = StoredVariable79;
				}
				System.Boolean prop81 = External.Has( (OperandVar80)); //IsContext = True IsNew = False
				OperandVar82 = prop81;
				if(ifResult78 = !(OperandVar82))
				{
					applicable = true;
					OperandVar83 = applicable;
				}
			}
			return (System.Boolean) (OperandVar83);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			
			
			root.AddComponent<Blackboards.personality>();
		}
        }
    }
    
    public class aged_generation_add : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar90 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.human StoredVariable84 = ((Blackboards.human)root.GetComponent(typeof(Blackboards.human))); //IsContext = True IsNew = False
			if(StoredVariable84 != null)
			{
				System.Boolean ifResult85; //IsContext = False IsNew = False
				System.Boolean OperandVar89 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.aged_generation OperandVar87 = default(Blackboards.aged_generation); //IsContext = False IsNew = False
				Blackboards.aged_generation StoredVariable86 = ((Blackboards.aged_generation)StoredVariable84.GetComponent(typeof(Blackboards.aged_generation))); //IsContext = True IsNew = False
				if(StoredVariable86 != null)
				{
					OperandVar87 = StoredVariable86;
				}
				System.Boolean prop88 = External.Has( (OperandVar87)); //IsContext = True IsNew = False
				OperandVar89 = prop88;
				if(ifResult85 = !(OperandVar89))
				{
					applicable = true;
					OperandVar90 = applicable;
				}
			}
			return (System.Boolean) (OperandVar90);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			
			
			root.AddComponent<Blackboards.aged_generation>();
		}
        }
    }
    
    public class historical_persons : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar99 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable91 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = True IsNew = False
			if(StoredVariable91 != null)
			{
				Lore StoredVariable92 = ((Lore)StoredVariable91.GetComponent(typeof(Lore))); //IsContext = True IsNew = False
				if(StoredVariable92 != null)
				{
					Place StoredVariable93 = ((Place)StoredVariable92.GetComponent(typeof(Place))); //IsContext = True IsNew = False
					if(StoredVariable93 != null)
					{
						System.Boolean ifResult94; //IsContext = False IsNew = False
						
						
						System.Collections.Generic.List<Agent> OperandVar96 = default(System.Collections.Generic.List<Agent>); //IsContext = False IsNew = False
						System.Collections.Generic.List<Agent> prop95 = StoredVariable93.Agents; //IsContext = False IsNew = False
						if(prop95 != null)
						{
							OperandVar96 = prop95;
						}
						
						
						
						System.Boolean OperandVar98 = default(System.Boolean); //IsContext = False IsNew = False
						
						System.Boolean prop97 = StoredVariable91.HasMarker( ("lore_pool")); //IsContext = False IsNew = False
						OperandVar98 = prop97;
						if(ifResult94 = ( (( ( (OperandVar96 != null ? OperandVar96.Count : 0))) == ( ( (0f))))) && ( ( (OperandVar98))))
						{
							applicable = true;
							OperandVar99 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar99);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			
			
			
			{
				Place subContext100 = (Place)root.GetComponent(typeof(Place)); //IsContext = True IsNew = False
				
				if(subContext100 != null)
				{
					
					subContext100.Size = (System.Int32)( (5f));
					System.Single OperandVar102 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop101 = External.Random( (1f), (4f)); //IsContext = True IsNew = False
					OperandVar102 = prop101;
					for (int i = 0; i <  (OperandVar102); i++)
					{
						UnityEngine.GameObject ag = new UnityEngine.GameObject("ag"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject ag103 = ag; //IsContext = True IsNew = False
							Entity AddContext104 = (Entity)ag.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
							
							{
								
								if(AddContext104 != null)
								{
									GODelegate Lambda105 = (UnityEngine.GameObject entity) => 
									{
										
										
										{
											
											if(entity != null)
											{
												
												{
													PlaceMarker subContext106 = (PlaceMarker)AddContext104.GetComponent(typeof(PlaceMarker)); //IsContext = True IsNew = False
													
													if(subContext106 != null)
													{
														
														{
															Place subContext107 = subContext106.CurrentPlace; //IsContext = True IsNew = False
															
															if(subContext107 != null)
															{
																Agent OperandVar109 = default(Agent); //IsContext = False IsNew = False
																Agent StoredVariable108 = ((Agent)subContext107.GetComponent(typeof(Agent))); //IsContext = True IsNew = False
																if(StoredVariable108 != null)
																{
																	OperandVar109 = StoredVariable108;
																}
																subContext107.Detach( (OperandVar109));
															}
														}
													}
												}
											}
										}
									};
									AddContext104.OnDestruction(Lambda105);
								}
							}
							Agent AddContext110 = (Agent)ag.AddComponent(typeof(Agent)); //IsContext = True IsNew = True
							Blackboards.historical_person AddContext111 = (Blackboards.historical_person)ag.AddComponent(typeof(Blackboards.historical_person)); //IsContext = True IsNew = True
							Blackboards.human AddContext112 = (Blackboards.human)ag.AddComponent(typeof(Blackboards.human)); //IsContext = True IsNew = True
							
							{
								
								if(AddContext112 != null)
								{
									System.Single OperandVar114 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop113 = External.Random( (20f), (45f)); //IsContext = True IsNew = False
									OperandVar114 = prop113;
									AddContext112.Age = (System.Int32)( (OperandVar114));
								}
							}
							Named AddContext115 = (Named)ag.AddComponent(typeof(Named)); //IsContext = True IsNew = True
							
							{
								
								if(AddContext115 != null)
								{
									
									
									
									
									
									System.String OperandVar117 = default(System.String); //IsContext = False IsNew = False
									System.String prop116 = External.RandomName(); //IsContext = False IsNew = False
									if(prop116 != null)
									{
										OperandVar117 = prop116;
									}
									AddContext115.Set( ("main_name"), ("_1"),( ( ("Historical person: "))) + ( ( (OperandVar117))));
								}
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(ag);
						Agent OperandVar119 = default(Agent); //IsContext = False IsNew = False
						Agent StoredVariable118 = ((Agent)ag.GetComponent(typeof(Agent))); //IsContext = True IsNew = False
						if(StoredVariable118 != null)
						{
							OperandVar119 = StoredVariable118;
						}
						subContext100.Attach( (OperandVar119));
					}
				}
			}
		}
        }
    }
}
